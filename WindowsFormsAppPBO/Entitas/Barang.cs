using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPBO.Entitas.Commons;

namespace WindowsFormsAppPBO.Entitas
{
    public class Barang : BaseEntitas
    {
        public string NamaBarang { get; set; }

        //Foreign Key
        public string IdKategori { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual IList<DetailBarang> DaftarDetailBarang { get; set; }
    }

    public class ValidatorBarang : AbstractValidator<Barang>
    {
        private readonly AppDbContext db;

        public ValidatorBarang(AppDbContext db)
        {
            this.db = db;

            RuleFor(b => b.Id).NotEmpty().WithName("Kode Barang").WithMessage("{PropertyName} belum diisi")
                .Matches(@"^B+[0-9]{3}$").When(b => !string.IsNullOrEmpty(b.Id), ApplyConditionTo.CurrentValidator)
                .WithMessage("{PropertyName} harus diawali huruf 'B' dan ikuti 3 digit angka");
            RuleFor(b => b.NamaBarang).NotEmpty().WithName("Nama Barang").WithMessage("{PropertyName} belum diisi");

            RuleFor(b => b.IdKategori).NotEmpty().WithName("Id Kategori").WithMessage("{PropertyName} belum diisi")
                .Must(id => db.TblKategori.Find(id) != null)
                .When(b => !string.IsNullOrEmpty(b.IdKategori), ApplyConditionTo.CurrentValidator)
                .WithMessage("Kategori dengan {PropertyName} {PropertyValue} tidak ada");

            RuleFor(b => b.DaftarDetailBarang).Must(daftar => daftar.Count > 0).WithName("Satuan")
                .WithMessage("{PropertyName} minimal harus 1");
        }
    }
}
