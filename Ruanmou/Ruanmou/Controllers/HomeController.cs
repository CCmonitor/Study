using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ruanmou.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "this is About Page by caientao";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "this is Contact Page by caientao";

            return View();
        }
    }
}