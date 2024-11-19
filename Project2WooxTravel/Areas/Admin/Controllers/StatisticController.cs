using Project2WooxTravel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class StatisticController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            var kategorisayisi = context.Categories.ToList().Count();
            ViewBag.kategorisayisi = kategorisayisi;
			var destinasyonsayisi = context.Destinations.ToList().Count();
			ViewBag.destinasyonsayisi = destinasyonsayisi;
			return View();
        }
    }
}