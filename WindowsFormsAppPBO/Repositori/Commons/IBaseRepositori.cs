using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPBO.Entitas.Commons;

namespace WindowsFormsAppPBO.Repositori.Commons
{
    public interface IBaseRepositori<T> where T : BaseEntitas
    {
        IList<T> GetAll();
        T Get(string id);
        T Add(T item);
        T Update(string id, T item);
        T Delete(string id);
    }
}
