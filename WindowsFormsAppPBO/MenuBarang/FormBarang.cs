using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPBO.Entitas;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsAppPBO.MenuBarang
{
    public partial class FormBarang : Form
    {
        private readonly AppDbContext db;

        public Barang SelectedBarang { get; set; }

        public FormBarang(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            var formTambahUbahBarang = new FormTambahUbahBarang(db);
            formTambahUbahBarang.EditMode = false;
            formTambahUbahBarang.ShowDialog();
            RefreshDataGridData();
        }

        private void RefreshDataGridData()
        {
            var listBarang = db.TblBarang.ToList();
            dataGridViewData.DataSource = listBarang.Select(b => new
            {
                b.KodeBarang,
                b.NamaBarang,
                b.Kategori?.NamaKategori
            }).ToList();
        }

        void RefreshDataGridDetail()
        {
            if (SelectedBarang != null)
            {
                var listDetail = db.TblBarang.Find(SelectedBarang.KodeBarang).DaftarDetailBarang.ToList();
                var listDataSource = listDetail.Select(dt => new
                {
                    dt.KodeSatuan,
                    dt.NamaSatuan,
                    Harga = $"{dt.HargaBarang:C2}",
                    Stok = dt.StokBarang
                }).ToList();
                dataGridViewDetail.DataSource = listDataSource;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridData();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormMain.Instance.Show();
            Close();
        }

        private void FormBarang_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.Instance.Show();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (SelectedBarang != null)
            {
                var formTambahUbahBarang = new FormTambahUbahBarang(db);
                formTambahUbahBarang.SelectedBarang = SelectedBarang;
                formTambahUbahBarang.EditMode = true;
                formTambahUbahBarang.ShowDialog();
                RefreshDataGridData();
            }
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string kodeBarang = dataGridViewData.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (kodeBarang != null)
                {
                    SelectedBarang = db.TblBarang.Include(b => b.Kategori)
                        .Include(b => b.DaftarDetailBarang)
                        .FirstOrDefault(b => b.KodeBarang == kodeBarang);
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewData.SelectedRows.Count <= 0)
                    throw new Exception("Click barang yang ingin dihapus terlebih dahulu!");

                var listBarangTerpilih = dataGridViewData.SelectedRows.OfType<DataGridViewRow>().Select(r => r.Cells[0].Value.ToString()).ToList();

                if (Utilitas.ShowConfirmation($"Yakin Menghapus {listBarangTerpilih.Count} Barang?") == true)
                {
                    foreach (var item in listBarangTerpilih)
                    {
                        var barang = db.TblBarang.Find(item);
                        db.TblBarang.Remove(barang);
                    }

                    db.SaveChanges();
                    Utilitas.ShowSuccess($"{listBarangTerpilih.Count} Barang berhasil dihapus!");
                    dataGridViewData.ClearSelection();
                    SelectedBarang = null;
                    RefreshDataGridData();
                }
            }
            catch (Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }

        private void FormBarang_Shown(object sender, EventArgs e)
        {
            RefreshDataGridData();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (SelectedBarang != null)
            {
                labelDetail.Text = $"Detail Barang : {SelectedBarang.KodeBarang}";
                RefreshDataGridDetail();
            }
        }
    }
}
