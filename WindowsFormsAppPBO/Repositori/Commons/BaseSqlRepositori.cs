﻿using System;
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
            var result = dbContext.Set<T>().Add(item);
            dbContext.SaveChanges();
            return result;
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
            var result = dbContext.Set<T>().Find(id);

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
            var result = dbContext.Set<T>().Find(id);
            if(result != null)
            {
                foreach(var property in result.GetType().GetProperties())
                {
                    property.SetValue(result, property.GetValue(item));
                }
                dbContext.SaveChanges();
            }
            return result;
        }
    }
}
