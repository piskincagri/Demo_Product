using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EntityFramework
{
    public class EfCustomerDAL : GenericRepository<Customer>, ICustomerDAL
    {
        public List<Customer> GetCustomerListWithJob()
        {
          
            using(var c = new Context())
            {

                return c.Customers.Include(x => x.Job).ToList();

            }


        }
    }
}
