using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
	public class AdminLayoutController : Controller
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

		public PartialViewResult PartialSidebar()
		{
			return PartialView();
		}

		public PartialViewResult PartialNavbar()
		{
			var username = Session["x"];
			var value = context.Admins.Where(x => x.Username == username).FirstOrDefault();

			return PartialView(value);
		}

		public PartialViewResult PartialFooter()
		{
			return PartialView();
		}

		public PartialViewResult PartialScript()
		{
			return PartialView();
		}
		public PartialViewResult PartialMessageNavbar()
		{
			var username = Session["x"];
			var email = context.Admins.Where(x => x.Username == username).Select(y => y.Email).FirstOrDefault();
			var incomingEmails = context.Messages.Where(x => x.ReceiverMail == email).ToList();
			var incomingEmailsCount = context.Messages.Where(x => x.ReceiverMail == email).Count();

			ViewBag.MessageCount = incomingEmailsCount;

			return PartialView(incomingEmails);
		}
		public PartialViewResult DestinationNavbar()
		{
			var destination = context.Destinations.OrderByDescending(x => x.DestinationId).Take(4).ToList();

			return PartialView(destination);
		}
	}
}