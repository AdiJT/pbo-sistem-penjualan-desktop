using FluentValidation;
using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using WindowsFormsAppPBO.Entitas;
using WindowsFormsAppPBO.Repositori.Commons;

namespace WindowsFormsAppPBO.MenuBarang
{
    public partial class FormTambahUbahBarang : Form
    {
        public bool EditMode { get; set; }
        public Barang SelectedBarang { get; set; }

        private List<DetailBarang> listDetail = new List<DetailBarang>();
        private DetailBarang SelectedDetailBarang = null;

        bool isBarangValid = true;
        bool isDetailValid = true;
        private readonly IBaseRepositori<Barang> repositoriBarang;
        private readonly IBaseRepositori<Kategori> repositoriKategori;
        private readonly IBaseRepositori<Satuan> repositoriSatuan;

        public FormTambahUbahBarang(IBaseRepositori<Barang> repositoriBarang,
            IBaseRepositori<Kategori> repositoriKategori,
            IBaseRepositori<Satuan> repositoriSatuan)
        {
            this.repositoriBarang = repositoriBarang;
            this.repositoriKategori = repositoriKategori;
            this.repositoriSatuan = repositoriSatuan;

            InitializeComponent();

            var listKategori = repositoriKategori.GetAll();
            if (listKategori.Count > 0)
            {
                comboBoxKategori.DataSource = listKategori;
                comboBoxKategori.DisplayMember = "NamaKategori";
                comboBoxKategori.ValueMember = "IdKategori";
                comboBoxKategori.SelectedIndex = 0;
            }

            var listSatuan = repositoriSatuan.GetAll();
            if(listSatuan.Count > 0)
            {
                comboBoxSatuan.DataSource = listSatuan;
                comboBoxSatuan.DisplayMember = "NamaSatuan";
                comboBoxSatuan.ValueMember = "KodeSatuan";
                comboBoxSatuan.SelectedIndex = 0;
            }

        }

        void RefreshDataGrid()
        {
            var dataSource = listDetail.Select(d => new
            {
                d.KodeSatuan,
                d.NamaSatuan,
                Harga = $"{d.HargaBarang:C2}",
                d.StokBarang,
            }).ToList();
            dataGridViewDetail.DataSource = dataSource;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTambahUbahBarang_Shown(object sender, EventArgs e)
        {
            if (SelectedBarang != null)
            {
                textBoxKodeBarang.Text = SelectedBarang.Id;
                textBoxNamaBarang.Text = SelectedBarang.NamaBarang;
                comboBoxKategori.SelectedItem = SelectedBarang.Kategori;

                listDetail = SelectedBarang.DaftarDetailBarang.ToList();

                for (int i = 0; i < listDetail.Count; i++)
                    listDetail[i].Satuan = repositoriSatuan.Get(listDetail[i].KodeSatuan);

                if (listDetail.Count > 0)
                {
                    comboBoxSatuan.SelectedItem = listDetail[0].Satuan;
                    textBoxHargaBarang.Text = listDetail[0].HargaBarang.ToString();
                    textBoxStok.Text = listDetail[0].StokBarang.ToString();
                }

                RefreshDataGrid();

                if (EditMode == true)
                    textBoxKodeBarang.Enabled = false;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                isBarangValid = true;

                foreach (Control control in panelBarang.Controls)
                    control.Focus();
                buttonSimpan.Focus();

                if (!isBarangValid)
                {
                    isBarangValid = true;
                    return;
                }

                if (EditMode == true)
                    EditBarang();
                else
                    TambahBarang();

                Close();
            }
            catch (ValidationException ex)
            {
                Utilitas.ShowError(string.Join("\n", ex.Errors.Select(ve => ve.ErrorMessage)));
            }
            catch(Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }

        void TambahBarang()
        {
            var kodeBarang = textBoxKodeBarang.Text;
            var namaBarang = textBoxNamaBarang.Text;
            var idKategori = comboBoxKategori.SelectedValue.ToString();
            
            var barangBaru = new Barang()
            {
                Id = kodeBarang,
                NamaBarang = namaBarang,
                IdKategori = idKategori,
            };
            
            var listDetailBaru = listDetail.Select(d => new DetailBarang()
            {
                KodeBarang = barangBaru.Id,
                KodeSatuan = d.KodeSatuan,
                HargaBarang = d.HargaBarang,
                StokBarang = d.StokBarang
            }).ToList();
            
            barangBaru.DaftarDetailBarang = listDetailBaru;
            
            var validator = new ValidatorBarang(AppDbContext.GetDbContext);
            validator.Validate(barangBaru, options => options.ThrowOnFailures());

            repositoriBarang.Add(barangBaru);
            
            Utilitas.ShowSuccess("Barang berhasil ditambahkan!");
        }

        void EditBarang()
        {
            var namaBarang = textBoxNamaBarang.Text;
            var idKategori = comboBoxKategori.SelectedValue?.ToString();

            SelectedBarang.NamaBarang = namaBarang;
            SelectedBarang.IdKategori = idKategori;

            var listDetailBaru = listDetail.Select(d => new DetailBarang()
            {
                KodeBarang = d.KodeBarang,
                KodeSatuan = d.KodeSatuan,
                HargaBarang = d.HargaBarang,
                StokBarang = d.StokBarang
            }).ToList();

            SelectedBarang.DaftarDetailBarang = listDetailBaru;

            repositoriBarang.Update(SelectedBarang.Id, SelectedBarang);

            Utilitas.ShowSuccess("Barang berhasil dirubah!");
        }

        private void dataGridViewDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var kodeSatuan = dataGridViewDetail.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (kodeSatuan != null)
            {
                var detail = listDetail.Find(db => db.KodeSatuan == kodeSatuan);
                if (detail != null)
                {
                    SelectedDetailBarang = detail;
                    buttonHapus.Enabled = true;
                }
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                isDetailValid = true;

                textBoxHargaBarang.Focus();
                textBoxStok.Focus();
                comboBoxSatuan.Focus();
                buttonTambah.Focus();

                if (!isDetailValid)
                {
                    isDetailValid = true;
                    return;
                }

                var kodeSatuan = comboBoxSatuan.SelectedValue.ToString();
                var harga = decimal.Parse(textBoxHargaBarang.Text);
                var stok = int.Parse(textBoxStok.Text);

                var satuan = repositoriSatuan.Get(kodeSatuan);

                var detailBaru = new DetailBarang()
                {
                    KodeSatuan = kodeSatuan,
                    HargaBarang = harga,
                    StokBarang = stok,
                    Satuan = satuan,
                };

                if (EditMode == true)
                    detailBaru.KodeBarang = SelectedBarang.Id;

                listDetail.Add(detailBaru);

                Utilitas.ShowSuccess("Satuan berhasil ditambahkan");
                RefreshDataGrid();
            }
            catch(Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }

        void ValidateTextBoxDetail<T>(string nama, Expression<Func<DetailBarang, object>> properti, TextBox textBox, Func<string ,T> parser, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                errorProvider1.SetError(textBox, null);

                var validator = new DetailBarangValidator(AppDbContext.GetDbContext);
                var strTextBox = textBox.Text.Trim();
                T nilai = default;
                var detail = new DetailBarang();

                if (strTextBox == "")
                    throw new Exception($"{nama} belum diisi");

                if(parser != null)
                    nilai = parser(strTextBox);

                detail.GetType().GetProperty(properti.GetMember().Name).SetValue(detail, nilai);

                validator.Validate(detail, options =>
                {
                    options.IncludeProperties(properti);
                    options.ThrowOnFailures();
                });

                isDetailValid = isDetailValid && true;
            }
            catch (ValidationException ex)
            {
                errorProvider1.SetError(textBox, string.Join("\n", ex.Errors.Select(ve => ve.ErrorMessage)));
                isDetailValid = isDetailValid && false;
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox, ex.Message);
                isDetailValid = isDetailValid && false;
                e.Cancel = true;
            }
        }

        void ValidateTextBoxBarang<T>(string nama, Expression<Func<Barang, object>> properti, TextBox textBox, Func<string, T> parser, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                errorProvider1.SetError(textBox, null);

                var validator = new ValidatorBarang(AppDbContext.GetDbContext);
                var strTextBox = textBox.Text.Trim();
                T nilai = default;
                var barang = new Barang();

                if (strTextBox == "")
                    throw new Exception($"{nama} belum diisi");

                if (parser != null)
                    nilai = parser(strTextBox);

                barang.GetType().GetProperty(properti.GetMember().Name).SetValue(barang, nilai);

                validator.Validate(barang, options =>
                {
                    options.IncludeProperties(properti);
                    options.ThrowOnFailures();
                });

                isBarangValid = isBarangValid && true;
            }
            catch (ValidationException ex)
            {
                errorProvider1.SetError(textBox, string.Join("\n", ex.Errors.Select(ve => ve.ErrorMessage)));
                isBarangValid = isBarangValid && false;
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox, ex.Message);
                isBarangValid = isBarangValid && false;
                e.Cancel = true;
            }
        }

        private void textBoxHargaBarang_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBoxDetail<decimal>("Harga", d => d.HargaBarang, textBoxHargaBarang, (s) => decimal.Parse(s), e);
        }

        private void textBoxStok_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBoxDetail<int>("Stok", d => d.StokBarang, textBoxStok, (s) => int.Parse(s), e);
        }

        private void comboBoxSatuan_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                errorProvider1.SetError(comboBoxSatuan, null);

                if (listDetail.Any(d => d.KodeSatuan == comboBoxSatuan.SelectedValue.ToString()))
                    throw new Exception("Satuan sudah ada");

                isDetailValid = isDetailValid && true;
            }
            catch(Exception ex)
            {
                errorProvider1.SetError(comboBoxSatuan, ex.Message);
                isDetailValid = isDetailValid && false;
                e.Cancel = true;
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            listDetail.Remove(SelectedDetailBarang);
            RefreshDataGrid();
        }

        private void textBoxKodeBarang_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBoxBarang<string>("Kode Barang", b => b.Id, textBoxKodeBarang, s => s, e);
        }

        private void textBoxNamaBarang_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBoxBarang<string>("Nama Barang", b => b.NamaBarang, textBoxNamaBarang, s => s, e);
        }
    }
}
