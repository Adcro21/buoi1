using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWeb1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult baibao()
        {
            ViewBag.Message = "Tao trang bao.";

            return View();
        }
        public ActionResult congthuc()
        {
            ViewBag.Message = "Cac cong thuc: ";

            return View();
        }
        public ActionResult bt2()
        {
            ViewBag.Message = "Tao bang.";

            return View();
        }

        public ActionResult bt2a()
        {
            ViewBag.Message = "Gop bang theo hang ngang.";

            return View();
        }
        public ActionResult bt2b()
        {
            ViewBag.Message = "Gop bang theo hang doc.";

            return View();
        }
        public ActionResult bt2c()
        {
            ViewBag.Message = "Gop cac o";

            return View();
        }
        public ActionResult bt3()
        {
            ViewBag.Message = "Tao CV.";

            return View();
        }
    }
}