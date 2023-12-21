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

namespace WindowsFormsAppPBO.MenuKonsumen
{
    public partial class FormKonsumen : Form
    {
        private readonly IBaseRepositori<Konsumen> repositoriKonsumen;

        private Konsumen SelectedKonsumen { get; set; }

        public FormKonsumen(IBaseRepositori<Konsumen> repositoriKonsumen)
        {
            this.repositoriKonsumen = repositoriKonsumen;
            InitializeComponent();
            RefreshDataGridData();
        }

        void RefreshDataGridData()
        {
            var listKonsumen = repositoriKonsumen.GetAll();
            var dataSource = listKonsumen.Select(k => new
            {
                k.Id,
                k.NamaKonsumen,
                k.NoHP,
                k.Alamat
            }).ToList();

            dataGridViewData.DataSource = dataSource;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKonsumen_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.Instance.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridData();
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var idKonsumen = dataGridViewData.Rows[e.RowIndex].Cells[0].Value.ToString();

            if(idKonsumen != null)
            {
                var konsumen = repositoriKonsumen.Get(idKonsumen);

                if (konsumen != null)
                    SelectedKonsumen = konsumen;
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewData.SelectedRows.Count <= 0)
                    throw new Exception("Pilih konsumen terlebih dahulu.\nKlik konsumen di tabel");
   
                var confirm = Utilitas.ShowConfirmation($"Hapus {dataGridViewData.SelectedRows.Count} konsumen?");

                if (confirm == false)
                    return;

                foreach(DataGridViewRow row in  dataGridViewData.SelectedRows)
                {
                    var idKonsumen = row.Cells[0].Value.ToString();
                    repositoriKonsumen.Delete(idKonsumen);
                }

                SelectedKonsumen = null;
                Utilitas.ShowSuccess($"{dataGridViewData.SelectedRows.Count} konsumen dihapus");
                RefreshDataGridData();              
            }
            catch(Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            var formTambah = new FormTambahUbahKonsumen(repositoriKonsumen) { Mode = FormMode.Add };
            formTambah.ShowDialog();
            RefreshDataGridData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (SelectedKonsumen != null)
            {
                var formUbah = new FormTambahUbahKonsumen(repositoriKonsumen)
                {
                    Mode = FormMode.Edit,
                    SelectedKonsumen = SelectedKonsumen
                };
                formUbah.ShowDialog();
                RefreshDataGridData();
            }
            else
                Utilitas.ShowError("Pilih konsumen terlebih dahulu.\nKlik konsumen di tabel");
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
