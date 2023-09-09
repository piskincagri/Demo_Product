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
    public class CustomerManager : ICustomerService
    {
        ICustomerDAL _customerDAL;
        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;

        }

        public List<Customer> GetCustomerListWithJob()
        {
            return _customerDAL.GetCustomerListWithJob();
        }

        public void TDelete(Customer t)
        {
            _customerDAL.Delete(t);
        }

        public Customer TGetById(int id)
        {
            return _customerDAL.GetById(id);
        }

        public List<Customer> TGetList()
        {
          return  _customerDAL.GetList();
        }

        public void TInsert(Customer t)
        {
            _customerDAL.Insert(t);

        }

        public void TUpdate(Customer t)
        {
            _customerDAL.Update(t);
        }
    }
}
