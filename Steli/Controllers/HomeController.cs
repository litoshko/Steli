using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steli.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Замовляйте натяжні стелі у нас.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Зв'яжіться з нами.";

            return View();
        }

        public ActionResult Prices()
        {
            ViewBag.Message = "Зв'яжіться з нами.";

            return View();
        }

        public ActionResult Offers()
        {
            ViewBag.Message = "Зв'яжіться з нами.";

            return View();
        }
    }
}
