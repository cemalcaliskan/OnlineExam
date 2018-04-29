using OnineSinav.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineSinav.Model;
using OnlineSinav.DAL.Concrete.EntityFramework.DAL;

namespace OnineSinav.BLL.Concrete
{
    class CategoryService : ICategoryService
    {
        EFCategoryDAL _categoryDAL;

        public CategoryService()
        {
            _categoryDAL = new EFCategoryDAL();
        }

        public void Add(Category entity)
        {
            _categoryDAL.Add(entity);
        }

        public void Delete(Category entity)
        {
            entity.IsActive = false;
            _categoryDAL.Update(entity);
        }

        public Category GetByID(int id)
        {
            return _categoryDAL.Get(a => a.CategoryID == id && a.IsActive);
            
        }

        public ICollection<Category> GetList()
        {
            return _categoryDAL.GetAll();
        }

        public void Update(Category entity)
        {
            _categoryDAL.Update(entity);
        }
    }
}
