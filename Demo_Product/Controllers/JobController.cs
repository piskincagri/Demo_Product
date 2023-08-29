using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Repositories.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Product.Controllers
{
    public class JobController : Controller
    {

       JobManager jobManager = new JobManager(new EfJopDAL());
        public IActionResult Index()
        {

            var values = jobManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddJob()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job p)
        {
           JobValidator validationRules = new JobValidator();

            ValidationResult results = validationRules.Validate(p);

            if (results.IsValid)
            {
                jobManager.TInsert(p);

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

        public IActionResult DeleteJob(int id)
        {
            var values = jobManager.TGetById(id);
            jobManager.TDelete(values);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = jobManager.TGetById(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateJob(Job p)
        {


            jobManager.TUpdate(p);

            return RedirectToAction("Index");

        }
    }
}
