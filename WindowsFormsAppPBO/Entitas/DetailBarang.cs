using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPBO.Entitas
{
    public class DetailBarang
    {
        //Primary key
        public string KodeBarang { get; set; }
        public string KodeSatuan { get; set; }

        public string NamaBarang { get => Barang.NamaBarang; }
        public string NamaSatuan { get => Satuan.NamaSatuan; }

        public decimal HargaBarang { get; set; }
        public int StokBarang { get; set; }

        public virtual Barang Barang { get; set; }
        public virtual Satuan Satuan { get; set; }
        public virtual IList<DetailTransaksi> DaftarDetailTransaksi { get; set; }
    }

    public class DetailBarangValidator : AbstractValidator<DetailBarang>
    {
        private readonly AppDbContext db;

        public DetailBarangValidator(AppDbContext db)
        {
            this.db = db;

            RuleFor(detail => detail.KodeBarang).NotEmpty().WithMessage("Kode Barang belum diisi...")
                .Must(kodeBarang => db.TblBarang.Find(kodeBarang) != null)
                .WithMessage("Barang dengan kode {PropertyValue} tidak ada");

            RuleFor(detail => detail.KodeSatuan).NotEmpty().WithMessage("Kode Satuan belum diisi...")
                 .Must(kodeSatuan => db.TblSatuan.Find(kodeSatuan) != null)
                 .WithMessage("Satuan dengan kode {PropertyValue} tidak ada");

            RuleFor(detail => detail.HargaBarang).NotEmpty().WithName("Harga").WithMessage("{PropertyName} belum diisi")
                .GreaterThan(0).WithMessage("{PropertyName} kurang dari {ComparisonValue}");

            RuleFor(detail => detail.StokBarang).NotEmpty().WithName("Stok").WithMessage("{PropertyName} belum diisi")
                .GreaterThan(0).WithMessage("{PropertyName} kurang dari {ComparisonValue}");
            
        }
    }
}
