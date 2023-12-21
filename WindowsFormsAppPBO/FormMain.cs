using FluentValidation;
using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPBO.Entitas;
using WindowsFormsAppPBO.MenuBarang;
using WindowsFormsAppPBO.MenuKategori;
using WindowsFormsAppPBO.MenuKonsumen;
using WindowsFormsAppPBO.MenuSatuan;
using WindowsFormsAppPBO.MenuTransaksi;
using WindowsFormsAppPBO.Repositori;
using WindowsFormsAppPBO.Repositori.Commons;

namespace WindowsFormsAppPBO
{
    public partial class FormMain : Form
    {
        private List<DetailTransaksi> DetailTransaksis { get; set; } = new List<DetailTransaksi>();
        private Barang currentBarang;
        private DetailBarang currentDetailBarang;
        private DetailTransaksi SelectedDetail = null;

        private bool isDetailTransaksiValid = false;
        private bool isTransaksiValid = false;

        private FormMain(IBaseRepositori<Transaksi> repositoriTransaksi, IBaseRepositori<Barang> repositoriBarang
            , IBaseRepositori<Konsumen> repositoriKonsumen)
        {
            InitializeComponent();
            this.repositoriTransaksi = repositoriTransaksi;
            this.repositoriBarang = repositoriBarang;
            this.repositoriKonsumen = repositoriKonsumen;
        }

        private static FormMain instance;
        private readonly IBaseRepositori<Transaksi> repositoriTransaksi;
        private readonly IBaseRepositori<Barang> repositoriBarang;
        private readonly IBaseRepositori<Konsumen> repositoriKonsumen;

        public static FormMain Instance { 
            get 
            {
                if(instance == null) instance = new FormMain(Utilitas.GetRepositoriTransaksi(), Utilitas.GetRepositoriBarang()
                    ,Utilitas.GetRepositoriKonsumen());
                return instance; 
            } 
        }

        void UpdateTotal()
        {
            decimal diskon = 0;
            if (!decimal.TryParse(textBoxDiskon.Text, out diskon))
                diskon = 0;
            var total = DetailTransaksis.Select(dt => dt.SubTotal).Sum();
            total = total - (diskon / 100) * total;
            labelTotal.Text = $"{total:C2}";
        }

        void RefreshDataGrid()
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = DetailTransaksis.Select(dt => new
            {
                dt.KodeBarang,
                dt.KodeSatuan,
                dt.NamaBarang,
                dt.NamaSatuan,
                HargaBarang = $"{dt.HargaBarang:C2}",
                dt.Jumlah
            }).ToList();
            dataGridViewData.Update();
            dataGridViewData.Refresh();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateChildren())
                {
                    TambahTransaksi();
                    Refresh();
                }
            }
            catch (ValidationException ex)
            {
                Utilitas.ShowError(string.Join("\n", ex.Errors.Select(er => er.ErrorMessage)));
            }
            catch (Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }

        private void TambahTransaksi()
        {
            var idTransaksi = Guid.NewGuid().ToString();
            var tanggal = dateTimePickerTanggalTransaksi.Value;
            var namaKonsumen = textBoxNamaKonsumen.Text.Trim();
            var listDetail = new List<DetailTransaksi>(DetailTransaksis);

            var strDiskon = textBoxDiskon.Text.Trim();
            if (strDiskon == "")
                throw new Exception("Diskon belum diisi!");
            if (!decimal.TryParse(strDiskon, out var diskon))
                throw new Exception("Format diskon salah");
            if (diskon < 0)
                throw new Exception("Diskon negatif");

            for (int i = 0; i < listDetail.Count; i++)
            {
                listDetail[i] = new DetailTransaksi
                {
                    IdTransaksi = idTransaksi,
                    KodeBarang = DetailTransaksis[i].KodeBarang,
                    KodeSatuan = DetailTransaksis[i].KodeSatuan,
                    NamaBarang = DetailTransaksis[i].NamaBarang,
                    NamaSatuan = DetailTransaksis[i].NamaSatuan,
                    HargaBarang = DetailTransaksis[i].HargaBarang,
                    Jumlah = DetailTransaksis[i].Jumlah
                };
            }

            var konsumen = repositoriKonsumen.GetAll().FirstOrDefault(k => k.NamaKonsumen == namaKonsumen);
            if(konsumen == null)
            {
                var formTambahKonsumen = new FormTambahUbahKonsumen(Utilitas.GetRepositoriKonsumen())
                {
                    SelectedKonsumen = new Konsumen
                    {
                        Id = Guid.NewGuid().ToString(),
                        NamaKonsumen = namaKonsumen
                    }, 
                    Mode = FormMode.Add
                };
                formTambahKonsumen.ShowDialog();
            }

            konsumen = repositoriKonsumen.GetAll().FirstOrDefault(k => k.NamaKonsumen == namaKonsumen);
            if (konsumen == null)
                throw new Exception($"Konsumen dengan nama {namaKonsumen} gagal ditambahkan");

            var transaksiBaru = new Transaksi()
            {
                Id = idTransaksi,
                Tanggal = tanggal,
                Diskon = diskon,
                DaftarDetailTransaksi = listDetail,
                IdKonsumen = konsumen.Id
            };

            var validator = new ValidatorTransaksi(repositoriKonsumen);
            validator.Validate(transaksiBaru, options => options.ThrowOnFailures());

            repositoriTransaksi.Add(transaksiBaru);
            Utilitas.ShowSuccess("Transaksi berhasil ditambahkan");

            var confirm = Utilitas.ShowConfirmation("Cetak Nota?");
            if(confirm)
            {
                var transaksi = repositoriTransaksi.Get(transaksiBaru.Id);
                var formCetak = new FormNota() { SelectedTransaksi = transaksi};
                formCetak.ShowDialog();
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void textBoxKodeBarang_TextChanged(object sender, EventArgs e)
        {
            buttonTambah.Enabled = false;
            textBoxJumlah.Enabled = false;
            comboBoxSatuan.Enabled = false;
            labelHasilCari.Text = "";
            currentBarang = null;
            currentDetailBarang = null;

            var kodeBarang = textBoxKodeBarang.Text.Trim();
            if (kodeBarang != "")
            {
                var barang = repositoriBarang.GetAll()
                    .Where(b => b.Id.Contains(kodeBarang)).FirstOrDefault();
                if (barang != null)
                {
                    labelHasilCari.Text = barang.NamaBarang;
                    currentBarang = barang;

                    var listSatuan = currentBarang.DaftarDetailBarang.ToList();
                    comboBoxSatuan.Enabled = true;
                    comboBoxSatuan.DataSource = listSatuan;
                    comboBoxSatuan.DisplayMember = "NamaSatuan";
                    comboBoxSatuan.ValueMember = "KodeSatuan";
                    comboBoxSatuan.SelectedIndex = 0;
                }
                else
                    labelHasilCari.Text = "Barang tidak ditemukan";
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentBarang == null)
                    throw new Exception("Masukan kode barang terlebih dahulu");

                if(currentDetailBarang == null)
                    throw new Exception("Pilih satuan terlebih dahulu");

                var strJumlah = textBoxJumlah.Text.Trim();

                if (strJumlah == "")
                    throw new Exception("Jumlah barang belum diisi!");
                if (!int.TryParse(strJumlah, out var jumlah))
                    throw new Exception("Format jumlah barang belum diisi");
                if (jumlah <= 0)
                    throw new Exception("Jumlah barang harus diatas 0!");
                if (jumlah > currentDetailBarang.StokBarang)
                    throw new Exception("Stok tidak cukup");

                var detailBaru = new DetailTransaksi()
                {
                    KodeBarang = currentBarang.Id,
                    KodeSatuan = currentDetailBarang.KodeSatuan,
                    NamaBarang = currentBarang.NamaBarang,
                    NamaSatuan = currentDetailBarang.NamaSatuan,
                    HargaBarang = currentDetailBarang.HargaBarang,
                    Jumlah = jumlah,
                };

                var detail = DetailTransaksis
                    .Find(dt => dt.KodeBarang == detailBaru.KodeBarang && dt.KodeSatuan == detailBaru.KodeSatuan);

                if (detail != null)
                {
                    if (detail.Jumlah + detailBaru.Jumlah > currentDetailBarang.StokBarang)
                        throw new Exception("Stok tidak cukup");

                    detail.Jumlah += detailBaru.Jumlah;
                    Utilitas.ShowSuccess("Jumlah Barang berhasil ditambahkan");
                }
                else
                {
                    DetailTransaksis.Add(detailBaru);
                    Utilitas.ShowSuccess("Barang berhasil ditambahkan pada transaksi");
                }

                UpdateTotal();
                RefreshDataGrid();
            }
            catch (Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }

        private void textBoxJumlah_TextChanged(object sender, EventArgs e)
        {
            labelSubTotal.Text = $"{0:C2}";
            if (currentBarang != null)
            {
                var strJumlah = textBoxJumlah.Text.Trim();

                if (strJumlah != "" && int.TryParse(strJumlah, out var jumlah) && jumlah > 0)
                    labelSubTotal.Text = $"{jumlah * currentDetailBarang.HargaBarang:C2}";
            }
        }

        private void textBoxDiskon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxDiskon_Validating(sender, new CancelEventArgs());
                if(isTransaksiValid)
                    UpdateTotal();
            }
            catch (Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (SelectedDetail != null)
            {
                DetailTransaksis.Remove(SelectedDetail);
                SelectedDetail = null;
                buttonHapus.Enabled = false;
                buttonHapus.Visible = false;
                UpdateTotal();
                RefreshDataGrid();
            }
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var kodeBarang = dataGridViewData.Rows[e.RowIndex].Cells[0].Value.ToString();
            var kodeSatuan = dataGridViewData.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (kodeBarang != null)
            {
                SelectedDetail = DetailTransaksis.Find(dt => dt.KodeBarang == kodeBarang && dt.KodeSatuan == kodeSatuan);
                buttonHapus.Enabled = true;
                buttonHapus.Visible = true;
            }
        }

        private void comboBoxSatuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxJumlah.Enabled = false;
            buttonTambah.Enabled = false;
            currentDetailBarang = null;

            if (currentBarang != null)
            {
                var kodeBarang = currentBarang.Id;
                var kodeSatuan = comboBoxSatuan.SelectedValue.ToString();

                currentDetailBarang = currentBarang.DaftarDetailBarang.FirstOrDefault(dt => dt.KodeSatuan == kodeSatuan);
                if (currentDetailBarang != null)
                {
                    textBoxJumlah.Enabled = true;
                    buttonTambah.Enabled = true;
                }
            }
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formBarang = new FormBarang(Utilitas.GetRepositoriBarang(), 
                Utilitas.GetRepositoriKategori(), Utilitas.GetRepositoriSatuan());
            this.Hide();
            formBarang.Show();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formKategori = new FormKategori(Utilitas.GetRepositoriKategori());
            this.Hide();
            formKategori.Show();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTransaksi = new FormTransaksi(repositoriTransaksi);
            this.Hide();
            formTransaksi.Show();
        }

        private void satuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSatuan = new FormSatuan(Utilitas.GetRepositoriSatuan());
            this.Hide();
            formSatuan.Show();
        }

        private void konsumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formKonsumen = new FormKonsumen(Utilitas.GetRepositoriKonsumen());
            this.Hide();
            formKonsumen.Show();
        }

        private CancelEventArgs ValidasiTextBox<T, TEntitas>(AbstractValidator<TEntitas> validator
            ,TextBox textBox ,Expression<Func<TEntitas, object>> property
            ,Func<string, T> parser ,CancelEventArgs e) where TEntitas : new()
        {
            try
            {
                errorProvider1.SetError(textBox, null);
                var text = textBox.Text.Trim();
                T value = default;
                if (text == "")
                    throw new Exception($"{property.GetMember().Name} belum diisi");

                value = parser(text);
                TEntitas entitas = new TEntitas();
                entitas.GetType().GetProperty(property.GetMember().Name).SetValue(entitas, value);

                validator.Validate(entitas, options =>
                {
                    options.IncludeProperties(property);
                    options.ThrowOnFailures();
                });

                return e;
            }
            catch (ValidationException ex)
            {
                errorProvider1.SetError(textBox, string.Join("\n", ex.Errors.Select(er => er.ErrorMessage)));
                e.Cancel = true;
                return e;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox, ex.Message);
                e.Cancel = true;
                return e;
            }
        }

        private void textBoxDiskon_Validating(object sender, CancelEventArgs e)
        {
            e = ValidasiTextBox(new ValidatorTransaksi(repositoriKonsumen), textBoxDiskon, t => t.Diskon, 
                s =>
                {
                    if (!decimal.TryParse(s, out var d))
                        throw new Exception("Format diskon salah");

                    return d;
                }, e);
            isTransaksiValid = !e.Cancel;
        }

        private void textBoxNamaKonsumen_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxNamaKonsumen, null);

            if (textBoxNamaKonsumen.Text.Trim() == "")
            {
                errorProvider1.SetError(textBoxNamaKonsumen, "Nama Konsumen belum diisi");
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            currentBarang = null;
            currentDetailBarang = null;
            DetailTransaksis = new List<DetailTransaksi>();
            SelectedDetail = null;
            isDetailTransaksiValid = false;
            isTransaksiValid = false;

            textBoxKodeBarang.Text = string.Empty;
            textBoxJumlah.Text = string.Empty;
            textBoxNamaKonsumen.Text = string.Empty;
            dateTimePickerTanggalTransaksi.Value = DateTime.Now;
            textBoxDiskon.Text = string.Empty;
            comboBoxSatuan.DataSource = null;

            errorProvider1.Clear();

            RefreshDataGrid();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
