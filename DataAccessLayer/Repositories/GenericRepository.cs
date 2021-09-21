using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T entity)
        {
            using Context context = new Context();
            context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            using Context context = new Context();
            context.Set<T>().Remove(entity);
        }

        public T GetById(int id)
        {
            using Context context = new Context();
            return context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            using Context context = new Context();
            return context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            using Context context = new Context();
            context.Set<T>().Update(entity);
        }
    }
}
