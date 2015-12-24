using MvcWebUdemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcWebUdemy.Models;

namespace MvcWebUdemy.Controllers
{
    public class HomeController : Controller
    {
        Database1Entities db = new Database1Entities();

        public ActionResult Index()
        {
            var alldepartments = db.Departments;

            return View(alldepartments);
        }

        public ActionResult About()
        {
            var xyz = new Person() { Name = "Sean" };

            ViewBag.Message = "Your application description page.";
            ViewBag.Location = "Los Angeles";
            return View(xyz);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details(int id)
        {
            var selectedDep = db.Departments.Single(d => d.Id == id);

            return View(selectedDep);
        }

        public ActionResult Create()
        {
            return View(new Department());
        }

        [HttpPost]
        public ActionResult Create(Department dep)
        {
            db.Departments.Add(dep);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}