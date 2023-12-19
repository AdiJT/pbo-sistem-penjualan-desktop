using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPBO.Entitas
{
    public class Kategori
    {
        [Key]
        public string IdKategori { get; set; }

        public string NamaKategori { get; set; }

        public virtual IList<Barang> DaftarBarang { get; set; }
    }

    public class ValidatorKategori : AbstractValidator<Kategori>
    {
        public ValidatorKategori()
        {
            RuleFor(k => k.IdKategori).NotEmpty().WithName("Kode Kategori")
                .WithMessage("{PropertyName} belum diisi")
                .Matches(@"^K+[0-9]{3}$").When(s => !string.IsNullOrEmpty(s.IdKategori), ApplyConditionTo.CurrentValidator)
                .WithMessage("Format {PropertyName} adalah K diikuti 3 digit angka");

            RuleFor(k => k.NamaKategori).NotEmpty().WithName("Nama Kategori")
                .WithMessage("{PropertyName} belum diisi");
        }
    }
}
