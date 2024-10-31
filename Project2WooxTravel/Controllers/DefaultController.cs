using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;

namespace Project2WooxTravel.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialBanner()
        {
            var values = context.Destinations.OrderByDescending(d => d.DestinationId).Take(4).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialCountry(int page = 1)
        {
            int pageSize = 3;
            // Varsayılan olarak 10 öğe sayfada gösterilecek
            var items = context.Destinations // Örneğin, bir tablo ya da liste
            .OrderBy(x => x.DestinationId)
                            .Skip((page - 1) * pageSize)
                            .Take(pageSize)
                            .ToList();
            // Toplam öğe sayısını alıyoruz
            int totalItemCount = context.Destinations.Count();

            // ViewModel veya ViewBag ile gönderiyoruz
            ViewBag.TotalItemCount = totalItemCount;
            ViewBag.PageSize = pageSize;
            ViewBag.CurrentPage = page;

            return PartialView(items);
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public ActionResult DestinationDetail(int id)
            {
            var values = context.Destinations.Find(id);
            return View(values);
           
        }
    }
}
