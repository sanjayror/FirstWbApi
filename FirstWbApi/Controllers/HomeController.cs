using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWbApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Login Page";

            return View("Login");
        }

        public ActionResult GLogin()
        {
            ViewBag.Title = "Login Page";

            return View();
        }

    }
}
