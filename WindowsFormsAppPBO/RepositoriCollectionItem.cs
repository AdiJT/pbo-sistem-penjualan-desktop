using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPBO.Entitas.Commons;
using WindowsFormsAppPBO.Repositori.Commons;

namespace WindowsFormsAppPBO
{
    public class RepositoriCollectionItem<T> where T : BaseEntitas
    {
        public Type Tipe { get; set; }
        public Func<IBaseRepositori<T>> Constructor { get; set; }
    }
}
