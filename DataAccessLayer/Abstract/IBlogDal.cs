using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal
    {
        List<Blog> ListAllCategory();
        Blog GetByIdCategory(int id);
        void AddCategory(Blog blog);
        void UpdateCategory(Blog blog);
        void DeleteCategory(Blog blog);
    }
}
