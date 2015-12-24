using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebUdemy.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Search(string name="*")
        {
            //return Content(name);
            //return RedirectToAction("Contact", "Home");
            return File(Server.MapPath("~/Content/Site.css"), "text/css");
        }
    }
}