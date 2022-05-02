using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //Listeleme
        {
            return View();
        }

        public ActionResult About() //Hakkında
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()// İletişim
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
    }
}