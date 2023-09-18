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
    public class ProductManager : IGenericService<Product>
    {
        IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void TDelete(Product t)
        {


            _productDAL.Delete(t);
        }

        public Product TGetById(int id)
        {
            return _productDAL.GetById(id);
        }

        public List<Product> TGetList()
        {
            return _productDAL.GetList();
        }

        public void TInsert(Product t)
        {
             _productDAL.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDAL.Update(t);
        }
    }
}
