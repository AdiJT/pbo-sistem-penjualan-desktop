using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPBO.Entitas.Commons;

namespace WindowsFormsAppPBO.Repositori.Commons
{
    public abstract class BaseSqlRepositori<T> : IBaseRepositori<T> where T : BaseEntitas
    {
        protected readonly AppDbContext dbContext;

        public BaseSqlRepositori(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public virtual T Add(T item)
        {
            if (dbContext.Set<T>().Find(item.Id) == null)
            {
                var result = dbContext.Set<T>().Add(item);
                dbContext.SaveChanges();
            }
            return null;
        }

        public virtual T Delete(string id)
        {
            var result = dbContext.Set<T>().Find(id);
            if(result != null)
            {
                dbContext.Set<T>().Remove(result);
                dbContext.SaveChanges();
            }

            return result;
        }

        public virtual T Get(string id)
        {
            var result = dbContext.Set<T>()
                .AsNoTracking().FirstOrDefault(x => x.Id == id);

            return result;
        }

        public virtual IList<T> GetAll()
        {
            var result = dbContext.Set<T>()
                .AsNoTracking().ToList();

            return result;
        }

        public virtual T Update(string id, T item)
        {
            var result = Get(id);
            if(result != null)
            {
                dbContext.Set<T>().AddOrUpdate(item);
                dbContext.SaveChanges();
            }
            return result;
        }
    }
}
