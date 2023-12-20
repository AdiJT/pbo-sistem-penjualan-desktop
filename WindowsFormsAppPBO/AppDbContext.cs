using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPBO.Entitas;

namespace WindowsFormsAppPBO
{
    public class AppDbContext : DbContext
    {
        private AppDbContext() : base("name=DefaultConnection")
        {
            
        }

        private static AppDbContext Instance;
        public static AppDbContext DbContext { 
            get
            {
                if(Instance == null) 
                    Instance = new AppDbContext();
                return Instance;
            } 
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Primary Key barang
            modelBuilder.Entity<Barang>()
                .HasKey(x => x.Id);

            //Primary Key detail transaksi
            modelBuilder.Entity<DetailTransaksi>()
                .HasKey(dt => new { dt.IdTransaksi, dt.KodeBarang , dt.KodeSatuan});

            //Primary Key Satuan
            modelBuilder.Entity<Satuan>()
                .HasKey(s => s.Id);

            //Primary Key Detail Barang
            modelBuilder.Entity<DetailBarang>()
                .HasKey(dt => new { dt.KodeBarang, dt.KodeSatuan });

            //Primary Key Konsumen
            modelBuilder.Entity<Konsumen>()
                .HasKey(k => k.Id);

            //Relasi barang - kategori
            modelBuilder.Entity<Barang>()
                .HasOptional(b => b.Kategori)
                .WithMany(k => k.DaftarBarang)
                .HasForeignKey(b => b.IdKategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kategori>()
                .HasMany(k => k.DaftarBarang)
                .WithOptional(b => b.Kategori);

            //Relasi transaksi - detail transaksi
            modelBuilder.Entity<DetailTransaksi>()
                .HasRequired(dt => dt.Transaksi)
                .WithMany(t => t.DaftarDetailTransaksi)
                .HasForeignKey(dt => dt.IdTransaksi)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Transaksi>()
                .HasMany(t => t.DaftarDetailTransaksi)
                .WithRequired(dt => dt.Transaksi);

            //Relasi detail barang - detail transaksi
            modelBuilder.Entity<DetailTransaksi>()
                .HasRequired(dt => dt.DetailBarang)
                .WithMany(db => db.DaftarDetailTransaksi)
                .HasForeignKey(dt => new { dt.KodeBarang, dt.KodeSatuan})
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<DetailBarang>()
                .HasMany(b => b.DaftarDetailTransaksi)
                .WithRequired(dt => dt.DetailBarang);

            //Relasi barang - detail barang
            modelBuilder.Entity<DetailBarang>()
                .HasRequired(dt => dt.Barang)
                .WithMany(b => b.DaftarDetailBarang)
                .HasForeignKey(dt => dt.KodeBarang)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Barang>()
                .HasMany(b => b.DaftarDetailBarang)
                .WithRequired(dt => dt.Barang);

            //Relasi satuan - detail barang
            modelBuilder.Entity<DetailBarang>()
                .HasRequired(dt => dt.Satuan)
                .WithMany(s => s.DaftarDetailBarang)
                .HasForeignKey(dt => dt.KodeSatuan)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Satuan>()
                .HasMany(s => s.DaftarDetailBarang)
                .WithRequired(dt => dt.Satuan);

            //Relasi konsumen - transaksi
            modelBuilder.Entity<Konsumen>()
                .HasMany(k => k.DaftarTransaksi)
                .WithRequired(t => t.Konsumen);

            modelBuilder.Entity<Transaksi>()
                .HasRequired(t => t.Konsumen)
                .WithMany(k => k.DaftarTransaksi)
                .HasForeignKey(t => t.IdKonsumen)
                .WillCascadeOnDelete(false);
        }

        public DbSet<Barang> TblBarang { get; set; }
        public DbSet<Kategori> TblKategori { get; set; }
        public DbSet<Transaksi> TblTransaksi { get; set; }
        public DbSet<DetailTransaksi> TblDetailTransaksi { get; set; }
        public DbSet<Satuan> TblSatuan { get; set; }
        public DbSet<DetailBarang> TblDetailBarang { get; set; }
        public DbSet<Konsumen> TblKonsumen { get; set; }
    }
}
