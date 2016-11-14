using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_kujna.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gotvaci()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "За да не контактирате, Ве молиме внесете ги следниве податоци";

            return View();
        }
    }
}