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
    public class RepositoriBarang : BaseSqlRepositori<Barang>
    {
        public RepositoriBarang(AppDbContext dbContext)
            :base(dbContext)
        {
            
        }

        public override Barang Get(string id)
        {
            var result = dbContext.TblBarang.Include(b => b.Kategori)
                .Include(b => b.DaftarDetailBarang).FirstOrDefault(b => b.KodeBarang == id);

            return result;
        }
    }
}
