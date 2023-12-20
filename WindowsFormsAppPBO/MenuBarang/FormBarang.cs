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
using WindowsFormsAppPBO.Repositori.Commons;

namespace WindowsFormsAppPBO.MenuBarang
{
    public partial class FormBarang : Form
    {
        private readonly IBaseRepositori<Barang> repositoriBarang;
        private readonly IBaseRepositori<Kategori> repositoriKategori;
        private readonly IBaseRepositori<Satuan> repositoriSatuan;

        public Barang SelectedBarang { get; set; }

        public FormBarang(IBaseRepositori<Barang> repositoriBarang, 
            IBaseRepositori<Kategori> repositoriKategori,
            IBaseRepositori<Satuan> repositoriSatuan)
        {
            InitializeComponent();
            this.repositoriBarang = repositoriBarang;
            this.repositoriKategori = repositoriKategori;
            this.repositoriSatuan = repositoriSatuan;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            var formTambahUbahBarang = new FormTambahUbahBarang(repositoriBarang, repositoriKategori,
                repositoriSatuan);
            formTambahUbahBarang.EditMode = false;
            formTambahUbahBarang.ShowDialog();
            RefreshDataGridData();
        }

        private void RefreshDataGridData()
        {
            var listBarang = repositoriBarang.GetAll();
            dataGridViewData.DataSource = listBarang.Select(b => new
            {
                b.Id,
                b.NamaBarang,
                b.Kategori?.NamaKategori
            }).ToList();
        }

        void RefreshDataGridDetail()
        {
            if (SelectedBarang != null)
            {
                var listDetail = repositoriBarang.Get(SelectedBarang.Id).DaftarDetailBarang.ToList();
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
                var formTambahUbahBarang = new FormTambahUbahBarang(repositoriBarang, repositoriKategori,
                    repositoriSatuan);
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
                    SelectedBarang = repositoriBarang.Get(kodeBarang);
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
                        repositoriBarang.Delete(item);
                    }

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
                labelDetail.Text = $"Detail Barang : {SelectedBarang.Id}";
                RefreshDataGridDetail();
            }
        }
    }
}
