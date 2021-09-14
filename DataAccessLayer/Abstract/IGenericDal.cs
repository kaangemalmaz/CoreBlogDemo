using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        List<T> ListAllCategory();
        T GetByIdCategory(int id);
        void AddCategory(T entity);
        void UpdateCategory(T entity);
        void DeleteCategory(T entity);
    }
}
