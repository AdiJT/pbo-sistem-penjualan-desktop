﻿using System;
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

namespace WindowsFormsAppPBO.MenuTransaksi
{
    public partial class FormTransaksi : Form
    {
        private readonly IBaseRepositori<Transaksi> repositoriTransaksi;

        public Transaksi SelectedTransaksi { get; set; }

        public FormTransaksi(IBaseRepositori<Transaksi> repositoriTransaksi)
        {
            InitializeComponent();
            this.repositoriTransaksi = repositoriTransaksi;
            RefreshDataGridData();
        }

        void RefreshDataGridData()
        {
            var listTransaksi = repositoriTransaksi.GetAll();
            var listTransaksiFormat = listTransaksi.Select(t =>
            new {
                t.Id,
                t.IdKonsumen,
                t.Konsumen?.NamaKonsumen,
                Tanggal = $"{t.Tanggal:d}",
                Diskon = $"{t.Diskon}%",
                Total = $"{t.Total:C2}"
            }).ToList();
            dataGridViewData.DataSource = listTransaksiFormat;
        }

        void RefreshDataGridDetail()
        {
            var listDetail = SelectedTransaksi.DaftarDetailTransaksi.ToList();
            var listDataSource = listDetail.Select(t => new
            {
                t.KodeBarang,
                t.NamaBarang,
                t.NamaSatuan,
                Harga = $"{t.HargaBarang:C2}",
                t.Jumlah,
                SubTotal = $"{t.SubTotal:C2}"
            }).ToList();
            dataGridViewDetail.DataSource = listDataSource;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            Close();
            FormMain.Instance.Show();
        }

        private void FormTransaksi_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.Instance.Show();
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string idTransaksi = dataGridViewData.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (idTransaksi != null)
                {
                    SelectedTransaksi = repositoriTransaksi.Get(idTransaksi);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridData();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewData.SelectedRows.Count <= 0)
                    throw new Exception("Pilih transaksi yang ingin dihapus terlebih dahulu!");

                if (Utilitas.ShowConfirmation($"Yakin Menghapus {dataGridViewData.SelectedRows.Count} Transaksi?") == true)
                {
                    foreach (DataGridViewRow item in dataGridViewData.SelectedRows)
                    {
                        var idTransaksi = item.Cells[0].Value.ToString();
                        repositoriTransaksi.Delete(idTransaksi);
                    }

                    Utilitas.ShowSuccess($"{dataGridViewData.SelectedRows.Count} Transaksi berhasil dihapus!");
                    dataGridViewData.ClearSelection();
                    SelectedTransaksi = null;
                    RefreshDataGridData();
                }
            }
            catch (Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }

        private void buttonCetakNota_Click(object sender, EventArgs e)
        {
            if(SelectedTransaksi != null)
            {
                var formNota = new FormNota();
                formNota.SelectedTransaksi = SelectedTransaksi;
                formNota.ShowDialog();
            }
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if(SelectedTransaksi != null)
            {
                labelDetailTransaksi.Text = $"Detail Transaksi : {SelectedTransaksi.Id}";
                RefreshDataGridDetail();
            }
        }
    }
}
