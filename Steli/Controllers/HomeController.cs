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
            ViewBag.Message = "Відгуки про нашу роботу.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Зв'яжіться з нами.";

            return View();
        }

        public ActionResult Prices()
        {
            ViewBag.Message = "Найкращі ціни тільки для Вас.";

            return View();
        }

        public ActionResult Offers()
        {
            ViewBag.Message = "Замовляйте та отримайте знижку.";

            return View();
        }

        public ActionResult test()
        {
            ViewBag.Message = "Замовляйте та отримайте знижку.";

            return View();
        }

        public ActionResult lz_split()
        {
            ViewBag.Message = "Замовляйте та отримайте знижку.";

            return View();
        }
    }
}
