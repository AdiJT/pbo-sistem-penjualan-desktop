using System;
using System.Collections.Generic;
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
    }
}
