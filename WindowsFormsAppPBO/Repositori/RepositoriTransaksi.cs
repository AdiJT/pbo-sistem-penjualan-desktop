using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using WindowsFormsAppPBO.Entitas;
using WindowsFormsAppPBO.Repositori.Commons;

namespace WindowsFormsAppPBO.Repositori
{
    public class RepositoriTransaksi : BaseSqlRepositori<Transaksi>
    {
        public RepositoriTransaksi(AppDbContext db) 
            : base(db)
        {
            
        }

        public override Transaksi Add(Transaksi item)
        {
            var transaksi = dbContext.TblTransaksi.Find(item.Id);
            if (transaksi == null)
            {
                foreach(var detail in item.DaftarDetailTransaksi)
                {
                    var detailBarang = dbContext.TblDetailBarang.Find(detail.KodeBarang, detail.KodeSatuan);
                    detailBarang.StokBarang -= detail.Jumlah;
                }

                dbContext.TblTransaksi.Add(item);
                dbContext.SaveChanges();
            }

            return transaksi;
        }

        public override IList<Transaksi> GetAll()
        {
            var result = dbContext.TblTransaksi.Include(t => t.Konsumen)
                .Include(t => t.DaftarDetailTransaksi)
                .ToList();

            return result;
        }

        public override Transaksi Get(string id)
        {
            var result = dbContext.TblTransaksi.Include(t => t.Konsumen)
                .Include(t => t.DaftarDetailTransaksi)
                .FirstOrDefault(t => t.Id == id);

            return result;
        }
    }
}
