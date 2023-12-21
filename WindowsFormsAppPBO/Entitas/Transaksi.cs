using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPBO.Entitas.Commons;
using WindowsFormsAppPBO.Repositori.Commons;

namespace WindowsFormsAppPBO.Entitas
{
    public class Transaksi : BaseEntitas
    {
        public DateTime Tanggal { get; set; }
        public decimal Total { get => DaftarDetailTransaksi.Select(dt => dt.SubTotal).Sum(); }
        public decimal Diskon { get; set; }

        //Foreign Key
        public string IdKonsumen { get; set; }

        public virtual Konsumen Konsumen { get; set; }
        public virtual ICollection<DetailTransaksi> DaftarDetailTransaksi { get; set; }

        [NotMapped]
        public decimal TotalBayar { get => Total - Total * (Diskon / 100); }

        public static string BuatNota(Transaksi transaksi)
        {
            var listKolom = new List<Kolom>()
            {
                new Kolom
                {
                    NamaEntitas = nameof(DetailTransaksi),
                    NamaProperti = "NamaBarang",
                    NamaKolom = "Nama Barang",
                    PanjangKolom = 25,
                    FormatString = ""
                },
                new Kolom
                {
                    NamaEntitas = nameof(DetailTransaksi),
                    NamaProperti = "NamaSatuan",
                    NamaKolom = "Satuan",
                    PanjangKolom = 25,
                    FormatString = ""
                },
                new Kolom
                {
                    NamaEntitas = nameof(DetailTransaksi),
                    NamaProperti = "HargaBarang",
                    NamaKolom = "Harga Barang",
                    PanjangKolom = 15,
                    FormatString = "{0:C2}"
                },
                new Kolom
                {
                    NamaEntitas = nameof(DetailTransaksi),
                    NamaProperti = "Jumlah",
                    NamaKolom = "Jumlah Barang",
                    PanjangKolom = 5,
                    FormatString = ""
                },
                new Kolom
                {
                    NamaEntitas = nameof(DetailTransaksi),
                    NamaProperti = "SubTotal",
                    NamaKolom = "Sub Total",
                    PanjangKolom = 15,
                    FormatString = "{0:C2}"
                }
            };

            string nota = "";

            nota += $"No Nota : {transaksi.Id}\n";
            nota += $"Nama    : {transaksi.Konsumen.NamaKonsumen}\n";
            nota += $"Alamat  : {transaksi.Konsumen.Alamat}\n";
            nota += $"No HP   : {transaksi.Konsumen.NoHP}\n";
            nota += $"Tanggal : {transaksi.Tanggal:d}\n\n";

            nota += Utilitas.BuatTabel(transaksi.DaftarDetailTransaksi.ToList(), listKolom, true) + "\n\n";

            nota += $"{"Total",-12} : {transaksi.Total:C2}\n";
            nota += $"{"Diskon",-12} : {transaksi.Diskon}%\n";
            nota += $"{"Total Bayar",-12} : {transaksi.TotalBayar:C2}";

            return nota;
        }
    }

    public class ValidatorTransaksi : AbstractValidator<Transaksi>
    {
        private readonly IBaseRepositori<Konsumen> repositoriKonsumen;

        public ValidatorTransaksi(IBaseRepositori<Konsumen> repositoriKonsumen)
        {

            RuleFor(t => t.Id).NotEmpty().WithName("ID Transaksi")
                .WithMessage("{PropertyName} belum diisi");

            RuleFor(t => t.Tanggal).NotNull().WithName("Tanggal Transaksi")
                .WithMessage("{PropertyName} belum diisi");

            RuleFor(t => t.Diskon).NotNull().WithName("Diskon")
                .WithMessage("{PropertyName} belum diisi")
                .GreaterThanOrEqualTo(0).WithMessage("{PropertyName} kurang dari {ComparisonValue}")
                .LessThanOrEqualTo(100).WithMessage("{PropertyName} lebih dari {ComparisonValue}");

            RuleFor(t => t.IdKonsumen).NotEmpty().WithName("Id Konsumen")
                .WithMessage("{PropertyName} belum diisi")
                .Must(id => repositoriKonsumen.Get(id) != null)
                .When(t => !string.IsNullOrEmpty(t.IdKonsumen), ApplyConditionTo.CurrentValidator)
                .WithMessage("{PropertyName} '{PropertyValue}' tidak ada");

            RuleFor(t => t.DaftarDetailTransaksi).Must(daftarDetail => daftarDetail.Count > 0)
                .WithName("Daftar Barang").WithMessage("Jumlah {PropertyName} kurang dari 0");
            this.repositoriKonsumen = repositoriKonsumen;
        }
    }
}
