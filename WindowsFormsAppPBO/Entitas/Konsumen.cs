using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsAppPBO.Entitas
{
    public class Konsumen
    {
        public string IdKonsumen { get; set; }
        public string NamaKonsumen { get; set; }
        public string NoHP { get; set; }
        public string Alamat { get; set; }

        public virtual IList<Transaksi> DaftarTransaksi { get; set; }
    }

    public class ValidatorKonsumen : AbstractValidator<Konsumen>
    {
        public ValidatorKonsumen()
        {
            RuleFor(k => k.IdKonsumen).NotEmpty().WithName("Id Konsumen")
                .WithMessage("{PropertyName} belum diisi");

            RuleFor(k => k.NamaKonsumen).NotEmpty().WithName("Nama Konsumen")
                .WithMessage("{PropertyName} belum diisi");

            RuleFor(k => k.NoHP).NotEmpty().NotEmpty().WithName("Nomor HP")
                .WithMessage("{PropertyName} belum diisi")
                .Matches(@"^((\+?62)|(08))\d{10}")
                .When(k => !string.IsNullOrEmpty(k.NoHP), ApplyConditionTo.CurrentValidator)
                .WithMessage("Format {PropertyName} salah");
                

            RuleFor(k => k.Alamat).NotEmpty().WithName("Alamat")
                .WithMessage("{PropertyName} belum diisi");
        }
    }
}
