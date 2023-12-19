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

        public override IList<Barang> GetAll()
        {
            var result = dbContext.TblBarang.Include(b => b.Kategori)
                .Include(b => b.DaftarDetailBarang).ToList();

            return result;
        }

        public override Barang Get(string id)
        {
            var result = dbContext.TblBarang.Include(b => b.Kategori)
                .Include(b => b.DaftarDetailBarang).FirstOrDefault(b => b.KodeBarang == id);

            return result;
        }

        public override Barang Update(string id, Barang item)
        {
            var result = dbContext.TblBarang.Find(id);
            if (result != null)
            {
                result.NamaBarang = item.NamaBarang;
                result.IdKategori = item.IdKategori;

                var listDetailLama = result.DaftarDetailBarang.ToList();
                foreach (var detail in listDetailLama)
                {
                    dbContext.TblDetailBarang.Attach(detail);
                    dbContext.TblDetailBarang.Remove(detail);
                }
                dbContext.SaveChanges();

                result.DaftarDetailBarang = item.DaftarDetailBarang.ToList();

                dbContext.SaveChanges();
            }

            return result;
        }
    }
}
