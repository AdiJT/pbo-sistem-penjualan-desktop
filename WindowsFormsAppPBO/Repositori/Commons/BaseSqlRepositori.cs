using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPBO.Repositori.Commons
{
    public abstract class BaseSqlRepositori<T> : IBaseRepositori<T> where T : class
    {
        protected readonly AppDbContext dbContext;

        public BaseSqlRepositori(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public virtual T Add(T item)
        {
            throw new NotImplementedException();
        }

        public virtual T Delete(string id)
        {
            throw new NotImplementedException();
        }

        public virtual T Get(string id)
        {
            var result = dbContext.Set<T>().Find(id);

            return result;
        }

        public virtual IList<T> GetAll()
        {
            var result = dbContext.Set<T>()
                .AsNoTracking().ToList();

            return result;
        }

        public virtual T Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
