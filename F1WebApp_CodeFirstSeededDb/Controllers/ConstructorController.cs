using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using F1WebApp_CodeFirstSeededDb.DAL;
using F1WebApp_CodeFirstSeededDb.Models;

namespace F1WebApp_CodeFirstSeededDb.Controllers
{
    public class ConstructorController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Constructor
        public ActionResult Index()
        {
            return View(db.Constructors.ToList());
        }

        // GET: Constructor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constructor constructor = db.Constructors.Find(id);
            if (constructor == null)
            {
                return HttpNotFound();
            }
            return View(constructor);
        }

        // GET: Constructor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Constructor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConstructorID,Name,Country,Age")] Constructor constructor)
        {
            if (ModelState.IsValid)
            {
                db.Constructors.Add(constructor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(constructor);
        }

        // GET: Constructor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constructor constructor = db.Constructors.Find(id);
            if (constructor == null)
            {
                return HttpNotFound();
            }
            return View(constructor);
        }

        // POST: Constructor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConstructorID,Name,Country,Age")] Constructor constructor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(constructor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(constructor);
        }

        // GET: Constructor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constructor constructor = db.Constructors.Find(id);
            if (constructor == null)
            {
                return HttpNotFound();
            }
            return View(constructor);
        }

        // POST: Constructor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Constructor constructor = db.Constructors.Find(id);
            db.Constructors.Remove(constructor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
