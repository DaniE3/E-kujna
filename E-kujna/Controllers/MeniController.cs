using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_kujna.Models;

using PagedList;
using PagedList.Mvc;



namespace E_kujna.Controllers
{
    public class MeniController : Controller
    {

        E_kujnaEntities storeDB = new E_kujnaEntities();

        // GET: /Meni/
        public ActionResult Index( )
        {
          
            var obroks = storeDB.Obroks.ToList();
            return View(obroks);
        }
        //
        // GET: /Meni/Browse?obrok=ImeO
        public ActionResult Browse(string obrok)
        {
            // Retrieve Genre and its Associated Albums from database
            var obrokModel = storeDB.Obroks.Include("Recepts").Single(o => o.ImeO == obrok);

            return View(obrokModel);
        }
        //
        // GET: /Meni/Details/5
        public ActionResult Details(int id)
        {
            var recept = storeDB.Recepts.Find(id);
            return View(recept);
        }

        public ActionResult Recepti(string movieGenre, string searchString, int?page)
        {
            var GenreLst = new List<string>();

            var GenreQry = from d in storeDB.Obroks
                           orderby d.ImeO
                           select d.ImeO;
            GenreLst.AddRange(GenreQry.Distinct());
            ViewBag.movieGenre = new SelectList(GenreLst);

            var movies = from m in storeDB.Recepts
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Kujna.ImeK.Contains(searchString));
            }

            if (string.IsNullOrEmpty(movieGenre))
                return View(movies.OrderBy(i =>i.ObrokId).ToPagedList(page ?? 1,12));
            else
            {
                return View(movies.Where(x => x.Obrok.ImeO == movieGenre).OrderBy(i =>i.ObrokId).ToPagedList(page ?? 1,12));
            }
        }


      
        
       }
}
    
