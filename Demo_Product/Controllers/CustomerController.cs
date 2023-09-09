using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Repositories.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Product.Controllers
{
    public class CustomerController : Controller
    {
        JobManager jobManager = new JobManager(new EfJopDAL());
        CustomerManager customerManager = new CustomerManager(new EfCustomerDAL());
        public IActionResult Index()
        {
            var values = customerManager.GetCustomerListWithJob();

            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {

           
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                          select new SelectListItem
                                          {
                                              Text=x.JobName,
                                              Value=x.JobID.ToString()

                                          }).ToList();

            ViewBag.v = values;
                return View();
           
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {

            CustomerValidator validationRules = new CustomerValidator();

            ValidationResult results = validationRules.Validate(p);

            if (results.IsValid)
            {
                customerManager.TInsert(p);
                return RedirectToAction("Index");



            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
          
        }

        public IActionResult DeleteCustomer(int id)
        {

            var value = customerManager.TGetById(id);
            customerManager.TDelete(value);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.JobName,
                                               Value = x.JobID.ToString()

                                           }).ToList();

            ViewBag.v = values;


            var value = customerManager.TGetById(id);
            return View(value);
           

        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        { 
            customerManager.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
