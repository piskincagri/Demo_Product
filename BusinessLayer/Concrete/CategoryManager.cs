using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : IGenericService<Category>
    {

        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {

            _categoryDAL = categoryDAL;
        }

        public void TDelete(Category t)
        {
            _categoryDAL.Delete(t);
        }

        public Category TGetById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public List<Category> TGetList()
        {
         return   _categoryDAL.GetList();
        }

        public void TInsert(Category t)
        {
            _categoryDAL.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDAL.Update(t);
        }
    }
}
