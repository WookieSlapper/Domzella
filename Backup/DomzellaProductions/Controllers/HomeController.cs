using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DomzellaProductions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the home of a programmer-in-training! This site is a work in progress. Things come and go. You'll see.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The Abridged Version of Me";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "My Recent Work (If you like what you see, hire me!)";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "A Place for My Ideas";

            return View();
        }

        public ActionResult Coding()
        {
            ViewBag.Message = "A Chronological Programming Spiritual Odyssey";

            return View();
        }
    }
}
