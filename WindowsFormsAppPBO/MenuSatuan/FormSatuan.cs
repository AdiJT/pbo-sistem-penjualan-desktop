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

namespace WindowsFormsAppPBO.MenuSatuan
{
    public partial class FormSatuan : Form
    {
        private readonly AppDbContext dbContext;
        private Satuan SelectedSatuan { get; set; }

        public FormSatuan(AppDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            RefreshDataGrid();
        }

        private void FormSatuan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.Instance.Show();
        }

        void RefreshDataGrid()
        {
            var listSatuan = dbContext.TblSatuan.ToList();
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
                var satuan = dbContext.TblSatuan.Find(kodeSatuan);
                
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
                            var satuan = dbContext.TblSatuan.Find(kodeSatuan);
                            dbContext.TblSatuan.Remove(satuan);
                        }
                        dbContext.SaveChanges();

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
            var formTambah = new FormTambahUbahSatuan(dbContext) { Mode = FormMode.Add };
            formTambah.ShowDialog();
            RefreshDataGrid();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (SelectedSatuan != null)
            {
                var formUbah = new FormTambahUbahSatuan(dbContext) { Mode = FormMode.Edit, SelectedSatuan = SelectedSatuan };
                formUbah.ShowDialog();
                RefreshDataGrid();
            }
            else
                Utilitas.ShowError("Pilih satuan yang ingin diubah!\nKlik satuan pada tabel.");
        }
    }
}
