using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_kujna.Models;

using PagedList;
using PagedList.Mvc;
using System.Data.Entity.SqlServer;
using System.Net;
using System.Data.Entity;



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
        public ActionResult Details(int id, string b_sostojka )
        {
            
            var recept = storeDB.Recepts.Find(id);
            return View(recept);
           

        }

        public ActionResult Recepti(string tip_Obrok,string tip_Kujna, string b_Sostojka, int?page)
        {
           
            var GenreLst = new List<string>();

            var GenreQry = from d in storeDB.Kujnas
                           orderby d.ImeK
                           select d.ImeK;
            GenreLst.AddRange(GenreQry.Distinct());
            ViewBag.tip_Kujna = new SelectList(GenreLst);

            /*
            var movies = from m in storeDB.Recepts
                         select m;*/

            var GenreLst2 = new List<string>();

            var GenreQry2 = from d in storeDB.Obroks
                           orderby d.ImeO
                           select d.ImeO;
            GenreLst2.AddRange(GenreQry2.Distinct());
            ViewBag.tip_Obrok = new SelectList(GenreLst2);



            var movies = from o in storeDB.Recepts
                          select o;

            if (!String.IsNullOrEmpty(b_Sostojka))

               return View(movies.Where(s => s.Tekst.Contains(b_Sostojka)).OrderBy(i => i.ReceptId).ToPagedList(page ?? 1,12));


           

            /**//*
            var dataset = storeDB.Recepts
    .Where(x => x.ObrokId == environmentid && x.ProcessName == processname && x.RemoteIP == remoteip && x.CommandLine == commandlinepart)
    .Select(x => new { x.ServerName, x.ProcessID, x.Username }).ToList();
            /***/
            


            if (!string.IsNullOrEmpty(tip_Obrok) && string.IsNullOrEmpty(tip_Kujna))
                return View(movies.Where(x => x.Obrok.ImeO == tip_Obrok).OrderBy(i => i.ObrokId).ToPagedList(page ?? 1, 12));


             if (!string.IsNullOrEmpty(tip_Kujna) && string.IsNullOrEmpty(tip_Obrok))
                return View(movies.Where(x => x.Kujna.ImeK == tip_Kujna).OrderBy(i => i.KujnaId).ToPagedList(page ?? 1, 12));


            if (!string.IsNullOrEmpty(tip_Kujna) && !string.IsNullOrEmpty(tip_Obrok))
                return View(movies.Where(x => x.Kujna.ImeK ==tip_Kujna && x.Obrok.ImeO == tip_Obrok).OrderBy(i => i.KujnaId).ToPagedList(page ?? 1, 12));

         //   if (!string.IsNullOrEmpty(movieGenre) && !string.IsNullOrEmpty(movieGenre2))
            else
            {

                return View(movies.OrderBy(i => i.ObrokId).ToPagedList(page ?? 1, 12));

            }


          

      

        }

        /*************************************/
        /*
        public ActionResult Recepti2()
        {
           var model = from e in entities
            where column1=16 and column2=24
            select e;
        }
        */
        // GET: Meni/Detali/5
        public ActionResult Detali(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recept recept = storeDB.Recepts.Find(id);
            if (recept == null)
            {
                return HttpNotFound();
            }
            ViewBag.KujnaId = new SelectList(storeDB.Kujnas, "KujnaId", "ImeK", recept.KujnaId);
            ViewBag.ObrokId = new SelectList(storeDB.Obroks, "ObrokId", "ImeO", recept.ObrokId);
            return View(recept);
        }

        // POST: Recepts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReceptId,ObrokId,KujnaId,ImeR,UrlSlika,Tekst")] Recept recept)
        {
            if (ModelState.IsValid)
            {
                storeDB.Entry(recept).State = EntityState.Modified;
                storeDB.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KujnaId = new SelectList(storeDB.Kujnas, "KujnaId", "ImeK", recept.KujnaId);
            ViewBag.ObrokId = new SelectList(storeDB.Obroks, "ObrokId", "ImeO", recept.ObrokId);
            return View(recept);
        }



        }      
       }

    
