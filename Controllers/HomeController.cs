using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ah412415_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My MIS4200 description.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is my contact Info.";

            return View();
        }
    }
}