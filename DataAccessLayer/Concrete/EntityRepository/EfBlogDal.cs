using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Concrete.EntityRepository
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {

        public List<Blog> GetListWithCategory()
        {
            using Context context = new Context();
            return context.Blogs.Include(i => i.Category).ToList();
        }
    }
}
