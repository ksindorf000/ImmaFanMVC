using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImmaFanMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "of tiny carvings.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Send a message!";

            return View();
        }

        public ActionResult Resources()
        {
            ViewBag.Message = "Here are some cool resources if you" + 
                " want to get into tiny carvings too!";

            return View();
        }
    }
}