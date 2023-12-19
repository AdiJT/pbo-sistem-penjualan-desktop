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
using WindowsFormsAppPBO.MenuBarang;

namespace WindowsFormsAppPBO.MenuKategori
{
    public partial class FormKategori : Form
    {
        private readonly AppDbContext db;

        public Kategori SelectedKategori { get; set; }

        public FormKategori(AppDbContext db)
        {
            this.db = db;
            InitializeComponent();
            RefreshDataGrid();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            var formTambahKategori = new FormTambahUbahKategori(db);
            formTambahKategori.Mode = FormMode.Add;
            formTambahKategori.ShowDialog();
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = db.TblKategori.Select(k => new
            {
                k.IdKategori,
                k.NamaKategori,
            }).ToList();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormMain.Instance.Show();
            Close();
        }

        private void FormKategori_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.Instance.Show();
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string kodeKategori = dataGridViewData.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (kodeKategori != null)
                {
                    SelectedKategori = db.TblKategori.Find(kodeKategori);
                }
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (SelectedKategori != null)
            {
                var formUbahKategori = new FormTambahUbahKategori(db);
                formUbahKategori.SelectedKategori = SelectedKategori;
                formUbahKategori.Mode = FormMode.Edit;
                formUbahKategori.ShowDialog();
                RefreshDataGrid();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewData.SelectedRows.Count <= 0)
                    throw new Exception("Click kategori yang ingin dihapus terlebih dahulu!");

                var listKategoriTerpilih = dataGridViewData.SelectedRows
                    .OfType<DataGridViewRow>()
                    .Select(r => r.Cells[0].Value.ToString()).ToList();

                if (Utilitas.ShowConfirmation($"Yakin Menghapus {listKategoriTerpilih.Count} Kategori?") == true)
                {
                    foreach (var item in listKategoriTerpilih)
                    {
                        var kategori = db.TblKategori.Find(item);
                        db.TblKategori.Remove(kategori);
                    }

                    db.SaveChanges();
                    Utilitas.ShowSuccess($"{listKategoriTerpilih.Count} Kategori berhasil dihapus!");
                    SelectedKategori = null;
                    dataGridViewData.ClearSelection();
                    RefreshDataGrid();
                }
            }
            catch (Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }
    }
}
