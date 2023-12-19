using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPBO.Entitas;

namespace WindowsFormsAppPBO.MenuSatuan
{
    public partial class FormTambahUbahSatuan : Form
    {
        private readonly AppDbContext dbContext;

        public FormMode Mode { get; set; } = FormMode.Add;
        public Satuan SelectedSatuan { get; set; }
        
        public FormTambahUbahSatuan(AppDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahUbahSatuan_Shown(object sender, EventArgs e)
        {
            if(Mode == FormMode.Edit)
            {
                labelJudul.Text = "Ubah Satuan";

                textBoxKodeSatuan.Text = SelectedSatuan.KodeSatuan;
                textBoxNamaSatuan.Text = SelectedSatuan.NamaSatuan;

                textBoxKodeSatuan.Enabled = false;
            }
        }

        private void textBoxKodeSatuan_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                errorProvider1.SetError(textBoxKodeSatuan, null);

                var kodeSatuan = textBoxKodeSatuan.Text.Trim();
                var satuan = new Satuan { KodeSatuan = kodeSatuan };

                var validator = new ValidatorSatuan();
                validator.Validate(satuan, options =>
                {
                    options.IncludeProperties(s => s.KodeSatuan);
                    options.ThrowOnFailures();
                });
            }
            catch(ValidationException ex)
            {
                errorProvider1.SetError(textBoxKodeSatuan, string.Join("\n", ex.Errors.Select(er => er.ErrorMessage)));
                e.Cancel = true;
            }
            catch(Exception ex)
            {
                errorProvider1.SetError(textBoxKodeSatuan, ex.Message);
                e.Cancel = true;
            }
        }

        private void textBoxNamaSatuan_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                errorProvider1.SetError(textBoxNamaSatuan, null);

                var namaSatuan = textBoxNamaSatuan.Text.Trim();
                var satuan = new Satuan { NamaSatuan = namaSatuan };

                var validator = new ValidatorSatuan();
                validator.Validate(satuan, options =>
                {
                    options.IncludeProperties(s => s.NamaSatuan);
                    options.ThrowOnFailures();
                });
            }
            catch (ValidationException ex)
            {
                errorProvider1.SetError(textBoxNamaSatuan, string.Join("\n", ex.Errors.Select(er => er.ErrorMessage)));
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxNamaSatuan, ex.Message);
                e.Cancel = true;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateChildren() == true)
                {
                    var kodeSatuan = textBoxKodeSatuan.Text.Trim();
                    var namaSatuan = textBoxNamaSatuan.Text.Trim();

                    var satuan = new Satuan
                    {
                        KodeSatuan = kodeSatuan,
                        NamaSatuan = namaSatuan
                    };

                    if (Mode == FormMode.Add)
                    {
                        if (dbContext.TblSatuan.Find(kodeSatuan) != null)
                            throw new Exception($"Simpan gagal, satuan dengan kode {kodeSatuan} sudah digunakan");
                    }

                    dbContext.TblSatuan.AddOrUpdate(satuan);
                    dbContext.SaveChanges();

                    var strMode = Mode == FormMode.Add ? "tambahkan" : "diubah";
                    Utilitas.ShowSuccess($"Satuan dengan kode {kodeSatuan} berhasil di {strMode}!");
                    Close();
                }
            }
            catch(Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }
    }
}
