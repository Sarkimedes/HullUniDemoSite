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
                var scores = db.Scores;
                ViewBag.Scores = scores.ToList().OrderBy(x => x.Moves).Take(5);
                return View();
            }
        }
    }
}
