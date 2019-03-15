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
using System.Diagnostics;

namespace F1WebApp_CodeFirstSeededDb.Controllers
{
    public class CarController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Car
        public ActionResult Index(string sortOrder, string sortString)
        {
            ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.YearSortParm = sortOrder == "Year" ? "year_desc" : "Year";
            ViewBag.WinsSortParm = sortOrder == "Wins" ? "wins_desc" : "Wins";
            ViewBag.PodiumsSortParm = sortOrder == "Podiums" ? "pods_desc" : "Podiums";
            ViewBag.PolesSortParm = sortOrder == "Poles" ? "poles_desc" : "Poles";
            ViewBag.DriverSortParm = sortOrder == "Driver" ? "driver_desc" : "Driver";
            ViewBag.ConstSortParm = sortOrder == "Constructor" ? "const_desc" : "Constructor";
            var cars = from c in db.Cars.Include(c => c.Driver).Include(c => c.Constructor)
                       select c;
            //if (!String.IsNullOrEmpty(sortString))
            //{
            //    cars = cars.Where(c => c.Name.Contains(sortString) || c.Constructor.Name.Contains(sortString) || c.Driver.FullName.Contains(sortString));
            //}
            switch (sortOrder)
            {
                case "name_desc":
                    cars.OrderByDescending(c => c.Name);
                    break;
                case "Year":
                    cars.OrderBy(c => c.Year);
                    break;
                case "year_desc":
                    cars.OrderByDescending(c => c.Year);
                    break;
                case "pods_desc":
                    cars.OrderByDescending(c => c.Podiums);
                    break;
                case "Podiums":
                    cars.OrderBy(c => c.Podiums);
                    break;
                case "Poles":
                    cars.OrderBy(c => c.Poles);
                    break;
                case "poles_desc":
                    cars.OrderByDescending(c => c.Poles);
                    break;
                case "Driver":
                    cars.OrderBy(c => c.Driver.FullName);
                    break;
                case "driver_desc":
                    cars.OrderByDescending(c => c.Driver.FullName);
                    break;
                case "Constructor":
                    cars.OrderBy(c => c.Constructor.Name);
                    break;
                case "const_desc":
                    cars.OrderByDescending(c => c.Constructor.Name);
                    break;
            }
            return View(cars);
        }

        // GET: Car/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            ViewBag.ConstructorID = new SelectList(db.Constructors, "ConstructorID", "Name");
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverID", "FirstName");
            return View();
        }

        // POST: Car/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarID,Name,Year,Wins,Podiums,FastestLaps,Poles,DriverID,ConstructorID")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ConstructorID = new SelectList(db.Constructors, "ConstructorID", "Name", car.ConstructorID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverID", "FirstName", car.DriverID);
            return View(car);
        }

        // GET: Car/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            ViewBag.ConstructorID = new SelectList(db.Constructors, "ConstructorID", "Name", car.ConstructorID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverID", "FirstName", car.DriverID);
            return View(car);
        }

        // POST: Car/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CarID,Name,Year,Wins,Podiums,FastestLaps,Poles,DriverID,ConstructorID")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ConstructorID = new SelectList(db.Constructors, "ConstructorID", "Name", car.ConstructorID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverID", "FirstName", car.DriverID);
            return View(car);
        }

        // GET: Car/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Car/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
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
