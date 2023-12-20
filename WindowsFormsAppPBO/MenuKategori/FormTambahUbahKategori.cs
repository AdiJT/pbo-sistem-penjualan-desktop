using FluentValidation;
using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPBO.Entitas;
using WindowsFormsAppPBO.Repositori.Commons;

namespace WindowsFormsAppPBO.MenuKategori
{
    public partial class FormTambahUbahKategori : Form
    {
        private readonly IBaseRepositori<Kategori> repositoriKategori;

        public Kategori SelectedKategori { get; set; }
        public FormMode Mode { get; set; }

        public FormTambahUbahKategori(IBaseRepositori<Kategori> repositoriKategori)
        {
            this.repositoriKategori = repositoriKategori;
            InitializeComponent();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTambahUbahKategori_Shown(object sender, EventArgs e)
        {
            if(SelectedKategori != null)
            {
                textBoxKodeKategori.Text = SelectedKategori.Id;
                textBoxNamaKategori.Text = SelectedKategori.NamaKategori;

                if (Mode == FormMode.Edit)
                    textBoxKodeKategori.Enabled = false;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateChildren() == true)
                {
                    string kodeKategori, namaKategori;

                    kodeKategori = textBoxKodeKategori.Text.Trim();
                    namaKategori = textBoxNamaKategori.Text.Trim();

                    var kategoriBaru = new Kategori()
                    {
                        Id = kodeKategori,
                        NamaKategori = namaKategori,
                    };

                    if (Mode == FormMode.Add)
                        repositoriKategori.Add(kategoriBaru);
                    else
                        repositoriKategori.Update(kategoriBaru.Id, kategoriBaru);

                    if (Mode == FormMode.Edit)
                        Utilitas.ShowSuccess($"Kategori dengan ID '{kodeKategori}' Sukses diubah!");
                    else
                        Utilitas.ShowSuccess($"Kategori dengan ID '{kodeKategori}' Sukses ditambahkan!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }

        private CancelEventArgs ValidasiTextBox<T, TEntitas>(AbstractValidator<TEntitas> validator
            , TextBox textBox, Expression<Func<TEntitas, object>> property
            , Func<string, T> parser, CancelEventArgs e) where TEntitas : new()
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

                e.Cancel = false;

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

        private void textBoxKodeKategori_Validating(object sender, CancelEventArgs e)
        {
            e = ValidasiTextBox<string, Kategori>(new ValidatorKategori(), textBoxKodeKategori,
                k => k.Id, s => s, e);

            if (!e.Cancel && Mode == FormMode.Add && repositoriKategori.Get(textBoxKodeKategori.Text.Trim()) != null)
            {
                errorProvider1.SetError(textBoxKodeKategori, $"Sudah ada kategori dengan kode {textBoxKodeKategori.Text.Trim()}");
            }
        }

        private void textBoxNamaKategori_Validating(object sender, CancelEventArgs e)
        {
            e = ValidasiTextBox<string, Kategori>(new ValidatorKategori(), textBoxNamaKategori,
                k => k.NamaKategori, s => s, e);
        }
    }
}
