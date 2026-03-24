using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Insuranc.Models;

namespace Insuranc.Controllers
{
    public class InsureeController : Controller
    {
        private InsurancEntities db = new InsurancEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Calculate the quote before saving
                insuree.Quote = CalculateQuote(insuree);

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // Quote calculation logic
        private decimal CalculateQuote(Insuree insuree)
        {
            decimal quote = 50m; // base monthly cost

            // Age calculation
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth.Date > DateTime.Now.AddYears(-age)) age--;

            // Age rules
            if (age <= 18)
                quote += 100;
            else if (age <= 25)
                quote += 50;
            else
                quote += 25;

            // Car year rules
            if (insuree.CarYear < 2000)
                quote += 25;
            if (insuree.CarYear > 2015)
                quote += 25;

            // Car make/model rules
            if (insuree.CarMake?.ToLower() == "porsche")
            {
                quote += 25;
                if (insuree.CarModel?.ToLower() == "911 carrera")
                {
                    quote += 25;
                }
                  
            }

            // Speeding tickets — $10 each
            quote += insuree.SpeedingTickets * 10;

            // DUI — add 25%
            if (insuree.DUI)
                quote *= 1.25m;

            // Full coverage — add 50%
            if (insuree.CoverageType)
                quote *= 1.50m;

            return quote;
        }

        // GET: Insuree/Admin
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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