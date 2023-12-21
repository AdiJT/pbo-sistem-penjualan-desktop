using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPBO.Entitas;
using WindowsFormsAppPBO.Repositori.Commons;

namespace WindowsFormsAppPBO.MenuSatuan
{
    public partial class FormSatuan : Form
    {
        private readonly IBaseRepositori<Satuan> repositoriSatuan;

        private Satuan SelectedSatuan { get; set; }

        public FormSatuan(IBaseRepositori<Satuan> repositoriSatuan)
        {
            this.repositoriSatuan = repositoriSatuan;
            InitializeComponent();
            RefreshDataGrid();
        }

        private void FormSatuan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.Instance.Show();
        }

        void RefreshDataGrid()
        {
            var listSatuan = repositoriSatuan.GetAll();
            var dataSource = listSatuan.Select(s => new
            {
                s.Id,
                s.NamaSatuan
            }).ToList();
            dataGridViewData.DataSource = dataSource;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain.Instance.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var kodeSatuan = dataGridViewData.Rows[e.RowIndex].Cells[0].Value.ToString();

            if(kodeSatuan != null)
            {
                var satuan = repositoriSatuan.Get(kodeSatuan);
                
                if(satuan != null)
                    SelectedSatuan = satuan;
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewData.SelectedRows.Count > 0)
                {
                    var confirm = Utilitas.ShowConfirmation($"Hapus {dataGridViewData.SelectedRows.Count} satuan?");
                    if (confirm == true)
                    {
                        foreach (var row in dataGridViewData.SelectedRows)
                        {
                            var kodeSatuan = (row as DataGridViewRow).Cells[0].Value.ToString();
                            repositoriSatuan.Delete(kodeSatuan);
                        }

                        SelectedSatuan = null;

                        Utilitas.ShowSuccess($"{dataGridViewData.SelectedRows.Count} satuan berhasil di hapus");
                        RefreshDataGrid();
                    }
                }
            }
            catch(Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            var formTambah = new FormTambahUbahSatuan(repositoriSatuan) { Mode = FormMode.Add };
            formTambah.ShowDialog();
            RefreshDataGrid();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (SelectedSatuan != null)
            {
                var formUbah = new FormTambahUbahSatuan(repositoriSatuan) { Mode = FormMode.Edit, SelectedSatuan = SelectedSatuan };
                formUbah.ShowDialog();
                RefreshDataGrid();
            }
            else
                Utilitas.ShowError("Pilih satuan yang ingin diubah!\nKlik satuan pada tabel.");
        }
    }
}
