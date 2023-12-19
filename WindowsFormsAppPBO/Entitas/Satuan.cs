using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPBO.Entitas
{
    public class Satuan
    {
        public string KodeSatuan { get; set; }
        public string NamaSatuan { get; set; }

        public virtual ICollection<DetailBarang> DaftarDetailBarang { get; set; }
    }

    public class ValidatorSatuan : AbstractValidator<Satuan>
    {
        public ValidatorSatuan()
        {
            RuleFor(s => s.KodeSatuan).NotEmpty().WithName("Kode Satuan")
                .WithMessage("{PropertyName} belum diisi")
                .Matches(@"^S+[0-9]{3}$").When(s => !string.IsNullOrEmpty(s.KodeSatuan), ApplyConditionTo.CurrentValidator)
                .WithMessage("Format {PropertyName} adalah S diikuti 3 digit angka");

            RuleFor(s => s.NamaSatuan).NotEmpty().WithName("Nama Satuan")
                .WithMessage("{PropertyName} belum diisi");
        }
    }
}
