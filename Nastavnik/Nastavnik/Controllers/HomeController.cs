using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nastavnik.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login stranica";

            return View();
        }

        public ActionResult Teachers()
        {
            ViewBag.Message = "Stranice nastavnika";

            return View();
        }
        public ActionResult Parents()
        {
            ViewBag.Message = "Stranica roditelja";

            return View();
        }
        public ActionResult Students()
        {
            ViewBag.Message = "Stranica učenika";

            return View();
        }
    }
}