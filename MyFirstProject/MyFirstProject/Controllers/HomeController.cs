using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "no actionResult";
        //}

        public ActionResult About()
        {
           // ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page (from ViewBag.Message).";

            return View();
        }
        public string Baba() { return "this is the Baba page"; }
    }
}