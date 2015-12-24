using MvcWebUdemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebUdemy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
    }
}