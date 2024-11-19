using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Project2WooxTravel.Context;
using Project2WooxTravel.Entities;

namespace Project2WooxTravel.Controllers
{
    public class LoginController : Controller
    {
        TravelContext context = new TravelContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = context.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);

            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["x"] = values.Username;
                return RedirectToAction("Index", "Profile", new { area = "Admin" });
            }
            else
            {
				ViewBag.AlertType = "error";
				ViewBag.AlertMessage = "Giriş bilgileri hatalı. Tekrar deneyin.";
				return View();
            }
           
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
    }
}
//using System.Web.Security;