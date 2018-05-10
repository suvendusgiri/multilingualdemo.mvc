using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MultiLingualDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChangeLanguage(string lang)
        {
            string culture = lang;

            HttpCookie langCookie = new HttpCookie("culture", lang);
            langCookie.Expires = DateTime.Now.AddYears(1);
            System.Web.HttpContext.Current.Response.Cookies.Add(langCookie);

            return RedirectToAction("Index", "Home");
        }
    }
}