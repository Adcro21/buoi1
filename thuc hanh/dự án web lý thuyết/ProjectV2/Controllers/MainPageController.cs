using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectV2.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage
        public ActionResult MainPage01()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "About.";
            return View();
        }
    }
   
}