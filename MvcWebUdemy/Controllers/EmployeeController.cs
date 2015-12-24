using MvcWebUdemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebUdemy.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Create(int departmentId)
        {
            var model = new Employee();
            model.Department_Id = departmentId;
            return View(model);
        }

        Database1Entities _db = new Database1Entities();
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                var department = _db.Departments.Single(d => d.Id == emp.Department_Id);
                department.Employees.Add(emp);
                _db.SaveChanges();
                return RedirectToAction("Details", "Home", new { id = emp.Department_Id });
            }

            return View(emp);
        }
    }
}