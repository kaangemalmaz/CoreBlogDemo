using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddCategory(Blog blog)
        {
            using Context context = new Context();
            context.Blogs.Add(blog);
        }

        public void DeleteCategory(Blog blog)
        {
            using Context context = new Context();
            context.Blogs.Remove(blog);
        }

        public Blog GetByIdCategory(int id)
        {
            using Context context = new Context();
            return context.Blogs.Find(id);
        }

        public List<Blog> ListAllCategory()
        {
            using Context context = new Context();
            return context.Blogs.ToList();
        }

        public void UpdateCategory(Blog blog)
        {
            using Context context = new Context();
            context.Blogs.Update(blog);
        }
    }
}
