using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HullUniDemoSite.Models;

namespace HullUniDemoSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            using (var db = new SpaceCheeseDb())
            {
                var scores = db.Scores.Take(5);
                ViewBag.Scores = scores.ToList();
                return View();
            }
        }
    }
}
