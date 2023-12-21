﻿using FluentValidation;
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
using WindowsFormsAppPBO.Repositori.Commons;

namespace WindowsFormsAppPBO.MenuKonsumen
{
    public partial class FormTambahUbahKonsumen : Form
    {
        private readonly IBaseRepositori<Konsumen> repositoriKonsumen;

        public Konsumen SelectedKonsumen { get; set; }
        public FormMode Mode { get; set; } = FormMode.Add;

        public FormTambahUbahKonsumen(IBaseRepositori<Konsumen> repositoriKonsumen)
        {
            InitializeComponent();
            this.repositoriKonsumen = repositoriKonsumen;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahUbahKonsumen_Shown(object sender, EventArgs e)
        {
            if (Mode == FormMode.Edit)
            {
                labelJudul.Text = "Ubah Konsumen";

                textBoxIdKonsumen.Text = SelectedKonsumen.Id;
                textBoxNamaKonsumen.Text = SelectedKonsumen.NamaKonsumen;
                textBoxNoHp.Text = SelectedKonsumen.NoHP;
                textBoxAlamat.Text = SelectedKonsumen.Alamat;

                textBoxIdKonsumen.Enabled = false;
            }

            if(SelectedKonsumen != null)
            {
                textBoxIdKonsumen.Text = SelectedKonsumen.Id;
                textBoxNamaKonsumen.Text = SelectedKonsumen.NamaKonsumen;
                textBoxNoHp.Text = SelectedKonsumen.NoHP;
                textBoxAlamat.Text = SelectedKonsumen.Alamat;
            }
        }

        private void textBoxIdKonsumen_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                errorProvider1.SetError(textBoxIdKonsumen, null);

                var idKonsumen = textBoxIdKonsumen.Text.Trim();
                var konsumen = new Konsumen { Id = idKonsumen };

                var validator = new ValidatorKonsumen();
                validator.Validate(konsumen, options =>
                {
                    options.IncludeProperties(k => k.Id);
                    options.ThrowOnFailures();
                });
            }
            catch (ValidationException ex)
            {
                errorProvider1.SetError(textBoxIdKonsumen, string.Join("\n", ex.Errors.Select(er => er.ErrorMessage)));
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxIdKonsumen, ex.Message);
                e.Cancel = true;
            }
        }

        private void textBoxNamaKonsumen_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                errorProvider1.SetError(textBoxNamaKonsumen, null);

                var namaKonsumen = textBoxNamaKonsumen.Text.Trim();
                var konsumen = new Konsumen { NamaKonsumen = namaKonsumen };

                var validator = new ValidatorKonsumen();
                validator.Validate(konsumen, options =>
                {
                    options.IncludeProperties(k => k.NamaKonsumen);
                    options.ThrowOnFailures();
                });
            }
            catch (ValidationException ex)
            {
                errorProvider1.SetError(textBoxNamaKonsumen, string.Join("\n", ex.Errors.Select(er => er.ErrorMessage)));
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxNamaKonsumen, ex.Message);
                e.Cancel = true;
            }
        }

        private void textBoxNoHp_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                errorProvider1.SetError(textBoxNoHp, null);

                var noHp = textBoxNoHp.Text.Trim();
                var konsumen = new Konsumen { NoHP = noHp };

                var validator = new ValidatorKonsumen();
                validator.Validate(konsumen, options =>
                {
                    options.IncludeProperties(k => k.NoHP);
                    options.ThrowOnFailures();
                });
            }
            catch (ValidationException ex)
            {
                errorProvider1.SetError(textBoxNoHp, string.Join("\n", ex.Errors.Select(er => er.ErrorMessage)));
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxNoHp, ex.Message);
                e.Cancel = true;
            }
        }
        
        private void textBoxAlamat_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                errorProvider1.SetError(textBoxAlamat, null);

                var alamat = textBoxAlamat.Text.Trim();
                var konsumen = new Konsumen { Alamat = alamat };

                var validator = new ValidatorKonsumen();
                validator.Validate(konsumen, options =>
                {
                    options.IncludeProperties(k => k.Alamat);
                    options.ThrowOnFailures();
                });
            }
            catch (ValidationException ex)
            {
                errorProvider1.SetError(textBoxAlamat, string.Join("\n", ex.Errors.Select(er => er.ErrorMessage)));
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxAlamat, ex.Message);
                e.Cancel = true;
            }
        }
        
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateChildren() == true)
                {
                    var idKonsumen = textBoxIdKonsumen.Text.Trim();
                    var namaKonsumen = textBoxNamaKonsumen.Text.Trim();
                    var noHp = textBoxNoHp.Text.Trim();
                    var alamat = textBoxAlamat.Text.Trim();

                    var Konsumen = new Konsumen
                    {
                        Id = idKonsumen,
                        NamaKonsumen = namaKonsumen,
                        NoHP = noHp,
                        Alamat = alamat,
                    };

                    if (Mode == FormMode.Add)
                    {
                        if (repositoriKonsumen.Get(idKonsumen) != null)
                            throw new Exception($"Simpan gagal, Konsumen dengan kode {idKonsumen} sudah digunakan");
                    }

                    if (Mode == FormMode.Add)
                        repositoriKonsumen.Add(Konsumen);
                    else
                        repositoriKonsumen.Update(Konsumen.Id, Konsumen);

                    var strMode = Mode == FormMode.Add ? "tambahkan" : "diubah";
                    Utilitas.ShowSuccess($"Konsumen dengan kode {idKonsumen} berhasil di {strMode}!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }
    }
}
