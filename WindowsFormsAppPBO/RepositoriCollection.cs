using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPBO.Entitas.Commons;
using WindowsFormsAppPBO.Repositori.Commons;

namespace WindowsFormsAppPBO
{
    public class RepositoriCollection
    {
        public ArrayList ListRepositori { get; set; } = new ArrayList();

        public void Add<T>(Func<IBaseRepositori<T>> constructor) where T : BaseEntitas
        {
            ListRepositori.Add(new RepositoriCollectionItem<T>
            {
                Tipe = typeof(T),
                Constructor = constructor
            });
        }

        public IBaseRepositori<T> Get<T>() where T : BaseEntitas
        {
            
        }
    }
}
