using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPBO.Entitas;
using WindowsFormsAppPBO.Repositori.Commons;

namespace WindowsFormsAppPBO.Repositori
{
    public class RepositoriKategori : BaseSqlRepositori<Kategori>
    {
        public RepositoriKategori(AppDbContext db)
            : base(db)
        {
            
        }
    }
}
