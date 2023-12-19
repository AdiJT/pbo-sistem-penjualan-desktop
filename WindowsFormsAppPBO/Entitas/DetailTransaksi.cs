using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FluentValidation;

namespace WindowsFormsAppPBO.Entitas
{
    public class DetailTransaksi
    {
        public string IdTransaksi { get; set; }
        public string KodeBarang { get; set; }
        public string KodeSatuan { get; set; }

        public string NamaBarang { get; set; }
        public string NamaSatuan { get; set; }
        public decimal HargaBarang { get; set; }
        public int Jumlah { get; set; }

        public virtual Transaksi Transaksi { get; set; }
        public virtual DetailBarang DetailBarang { get; set; }

        [NotMapped]
        public decimal SubTotal { get => HargaBarang * Jumlah; }
    }

    public class ValidatorDetailTransaksi : AbstractValidator<DetailTransaksi>
    {
        private readonly AppDbContext _dbContext;

        public ValidatorDetailTransaksi(AppDbContext dbContext)
        {
            this._dbContext = dbContext;

            RuleFor(dt => dt.IdTransaksi).NotEmpty().WithName("Id Transaksi")
                .WithMessage("{PropertyName} belum diisi")
                .Must(id => _dbContext.TblTransaksi.Find(id) != null)
                .When(dt => !string.IsNullOrEmpty(dt.IdTransaksi), ApplyConditionTo.CurrentValidator)
                .WithMessage("{PropertyName} '{PropertyValue}' tidak ada");

            RuleFor(dt => dt.KodeBarang).NotEmpty().WithName("Kode Barang")
                .WithMessage("{PropertyName} belum diisi")
                .Must(id => _dbContext.TblBarang.Find(id) != null)
                .When(dt => !string.IsNullOrEmpty(dt.KodeBarang), ApplyConditionTo.CurrentValidator)
                .WithMessage("{PropertyName} '{PropertyValue}' tidak ada");

            RuleFor(dt => dt.KodeSatuan).NotEmpty().WithName("Kode Satuan")
                .WithMessage("{PropertyName} belum diisi")
                .Must(id => _dbContext.TblSatuan.Find(id) != null)
                .When(dt => !string.IsNullOrEmpty(dt.KodeSatuan), ApplyConditionTo.CurrentValidator)
                .WithMessage("{PropertyName} '{PropertyValue}' tidak ada");

            RuleFor(dt => dt.NamaBarang).NotEmpty().WithName("Nama Barang")
                .WithMessage("{PropertyName} belum diisi");

            RuleFor(dt => dt.NamaSatuan).NotEmpty().WithName("Nama Satuan")
                .WithMessage("{PropertyName} belum diisi");

            RuleFor(dt => dt.HargaBarang).GreaterThan(0).WithName("Harga Barang")
                .WithMessage("{PropertyName} kurang dari atau sama dengan {ComparisonValue}");

            RuleFor(dt => dt.Jumlah).LessThanOrEqualTo(dt => dt.DetailBarang.StokBarang).WithName("Jumlah Barang")
                .WithMessage("{PropertyName} lebih dari {ComparisonName}");
        }
    }
}
