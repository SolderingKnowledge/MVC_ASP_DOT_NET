using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ASP_DOT_NET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ab()
        {
            ViewBag.Message = "About page is here";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page is here";

            return View();
        }
    }
}