using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;
using System;
using System.Linq;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

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

        public PartialViewResult PartialCountry(int sayfa = 1)
        {
            var item = context.Destinations.ToList().ToPagedList(sayfa, 3);
            return PartialView(item);
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
        public PartialViewResult DestinationDetail2(int id)
        {
            var values = context.Destinations.Find(id);
            return PartialView(values);

        }

		[HttpGet]
		public ActionResult ReservationModal()
		{
			return PartialView();
		}

		[HttpPost]
		public ActionResult ReservationModal(Reservation reservation)
		{
			try
			{
				reservation.CreatedAt = DateTime.Now;
				context.Reservations.Add(reservation);
				context.SaveChanges();

				return Json(new { success = true, message = "Rezervasyonunuz başarıyla oluşturuldu." });
			}
			catch (Exception ex)
			{
				return Json(new { success = false, message = "Rezervasyon oluşturulurken bir hata oluştu." });
			}
		}
	}
}
