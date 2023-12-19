using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPBO.Repositori.Commons
{
    public interface IBaseRepositori<T> where T : class
    {
        IList<T> GetAll();
        T Get(string id);
        T Add(T item);
        T Update(T item);
        T Delete(string id);
    }
}
