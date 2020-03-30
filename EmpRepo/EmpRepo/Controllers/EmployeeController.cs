using EmpRepo.Models;
using EmpRepo.Repository.Contract;
using EmpRepo.Repository.Contract.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpRepo.Controllers
{
    public class EmployeeController : Controller
    {
        //GET: Employee
        public ActionResult Index()
        {
            IUnitOfWork iu = new UnitOfWork(new EmpContext());
            List<Employee> lc = iu.Employees.GetAll().ToList();
            return View(lc);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {
            if (ModelState.IsValid)
            {
                IUnitOfWork iu = new UnitOfWork(new EmpContext());
                iu.Employees.Add(e);
                iu.Complete();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}