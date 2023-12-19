using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                .FirstOrDefault(t => t.IdTransaksi == id);

            return result;
        }
    }
}
