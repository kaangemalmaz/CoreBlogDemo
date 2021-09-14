﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        public void AddCategory(Category category)
        {
            using (Context context = new Context())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public void DeleteCategory(Category category)
        {
            using (Context context = new Context())
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }

        public Category GetByIdCategory(int id)
        {
            using (Context context = new Context())
            {
                return context.Categories.Find(id);
            }
        }

        public List<Category> ListAllCategory()
        {
            using (Context context = new Context())
            {
                return context.Categories.ToList();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (Context context = new Context())
            {
                context.Categories.Update(category);
                context.SaveChanges();
            }
        }
    }
}
