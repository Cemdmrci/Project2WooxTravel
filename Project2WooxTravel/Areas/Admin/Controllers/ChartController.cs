using Project2WooxTravel.Context; // Veritabanı bağlamını (context) kullanmak için gerekli kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
	public class ChartController : Controller
	{
		TravelContext context = new TravelContext();

		public ActionResult Line()
		{
			var messageSubjects = context.Messages.Select(m => m.Subject).Distinct().ToList();

			var messageCounts = context.Messages
										.GroupBy(m => m.Subject)  // Mesajları konuya göre grupla
										.Select(g => g.Count())   // Her gruptaki mesaj sayısını al
										.ToList();
			
			if (messageSubjects == null || messageSubjects.Count == 0)
			{
				Console.WriteLine("MessageSubjects boş.");
			}
			if (messageCounts == null || messageCounts.Count == 0)
			{
				Console.WriteLine("MessageCounts boş.");
			}

			ViewBag.MessageSubjects = messageSubjects;
			ViewBag.MessageCounts = messageCounts;

			return View(); // Görünümü render et
		}

		public ActionResult Bar()
		{
			var currentMonth = DateTime.Now.Month;
			var currentYear = DateTime.Now.Year;

			var reservations = context.Reservations
				.Where(r => r.ReservationStartDate.Month == currentMonth && r.ReservationStartDate.Year == currentYear)
				.ToList();

			var personCounts = new int[DateTime.DaysInMonth(currentYear, currentMonth)];

			foreach (var reservation in reservations)
			{
				var day = reservation.ReservationStartDate.Day;  // Gün bilgisi
				personCounts[day - 1] += reservation.PersonCount; // İlgili günün kişi sayısını artır
			}

			ViewBag.PersonCounts = personCounts;
			ViewBag.Days = Enumerable.Range(1, personCounts.Length).ToList(); // 1'den son güne kadar sıralı bir liste oluştur

			return View(); // Görünümü render et
		}

		public ActionResult Pie()
		{
			var destinations = context.Destinations
				.Select(d => new
				{
					Title = d.Title,   // Başlık
					Capacity = d.Capacity  // Kapasite
				})
				.ToList();

			ViewBag.DestinationTitles = destinations.Select(d => d.Title).ToList();
			ViewBag.DestinationCapacities = destinations.Select(d => d.Capacity).ToList();

			return View(); // Görünümü render et
		}

		public ActionResult Doughnut()
		{
			var destinations = context.Destinations
				.Select(d => new
				{
					Title = d.Title,   // Başlık
					Price = d.Price    // Fiyat
				})
				.ToList();

			ViewBag.DestinationTitles = destinations.Select(d => d.Title).ToList();
			ViewBag.DestinationPrices = destinations.Select(d => d.Price).ToList();

			return View(); // Görünümü render et
		}
	}
}
