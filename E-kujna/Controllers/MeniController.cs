using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_kujna.Models;

namespace E_kujna.Controllers
{
    public class MeniController : Controller
    {
        E_kujnaEntities storeDB = new E_kujnaEntities();
        // GET: Recept
        public ActionResult Index()
        {
            var obroks = storeDB.Obroks.ToList();
            return View(obroks);
        }

        public ActionResult Browse(string obrok)
        {
            // Retrieve Genre and its Associated Albums from database
            var obrokModel = storeDB.Obroks.Include("Recepti")
                .Single(o => o.Name == obrok);

            return View(obrokModel);
        }


        public ActionResult Details(int id)
        {
            var recept = storeDB.Recepts.Find(id);

            return View(recept);
        }


        [ChildActionOnly]
        public ActionResult ObrokMenu()
        {
            var obroks = storeDB.Obroks.ToList();
            return PartialView(obroks);
        }
    }
}