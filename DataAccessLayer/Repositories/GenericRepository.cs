using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T entity)
        {
            using Context context = new Context();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using Context context = new Context();
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T GetById(Expression<Func<T, bool>> filter)
        {
            using Context context = new Context();
            return context.Set<T>().SingleOrDefault(filter);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null) 
        {
            using Context context = new Context();
            return filter == null 
                ? context.Set<T>().ToList()
                : context.Set<T>().Where(filter).ToList();
        }

        public void Update(T entity)
        {
            using Context context = new Context();
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
