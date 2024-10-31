using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        // GET: Admin/Message
        TravelContext context = new TravelContext();
        public ActionResult Inbox()
        {
            var a = Session["x"]; //Giriş yapan kullanıcının kullanıcı adını aldım.
            var email = context.Admins.Where(x => x.Username == a).Select(y => y.Email).FirstOrDefault(); //Bu kullanıcı adına ait emaili aldım.
            var values = context.Messages.Where(x => x.ReceiverMail == email).ToList(); //Bu emaile ait gelen mailleri aldım.
            return View(values);

        }
        public ActionResult Sendbox()
        {
            var a = Session["x"];
            var email = context.Admins.Where(x => x.Username == a).Select(y => y.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.ReceiverMail == email).ToList();
            return View(values);
        }
        public ActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            var a = Session["x"];
            var email = context.Admins.Where(x => x.Username == a).Select(y => y.Email).FirstOrDefault();
            message.SenderMail = email; //Mesajın göndericisi login olan kullanıcı olur.
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Sendbox", "Message", new { area = "Admin" });
        }
    }
}