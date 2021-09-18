using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.AddCategory(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.DeleteCategory(category);
        }

        public Category GetByIdCategory(int id)
        {
            return _categoryDal.GetByIdCategory(id);
        }

        public List<Category> ListAllCategory()
        {
            return _categoryDal.ListAllCategory();
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.UpdateCategory(category);
        }
    }
}
