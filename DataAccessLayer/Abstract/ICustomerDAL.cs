using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
 public   interface ICustomerDAL
    {


        void Insert(Customer p);

        void Delete(Customer p);

        void Update(Customer p);

        List<Customer> GetList();
    }
}
