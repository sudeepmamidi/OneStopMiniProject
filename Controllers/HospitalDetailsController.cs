using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OneStopMiniProject.Models;

namespace OneStopMiniProject.Controllers
{
    public class HospitalDetailsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: HospitalDetails
        public ActionResult Index()
        {
            if (Session["admin_id"] != null)
            {
                return View(db.HospitalDetails.ToList());
            }
            else
            {
                return RedirectToAction("Login","Admin");
            }
           
        }

        // GET: HospitalDetails/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalDetails hospitalDetails = db.HospitalDetails.Find(id);
            if (hospitalDetails == null)
            {
                return HttpNotFound();
            }
            return View(hospitalDetails);
        }

        // GET: HospitalDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HospitalDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HospitalID,HospitalName,HospitalCity,HospitalState,Zip,Certification,Operations,Achivements,Facilities,Category,Approved")] HospitalDetails hospitalDetails)
        {
            if (ModelState.IsValid)
            {
                db.HospitalDetails.Add(hospitalDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hospitalDetails);
        }

        // GET: HospitalDetails/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalDetails hospitalDetails = db.HospitalDetails.Find(id);
            if (hospitalDetails == null)
            {
                return HttpNotFound();
            }
            return View(hospitalDetails);
        }

        // POST: HospitalDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HospitalID,HospitalName,HospitalCity,HospitalState,Zip,Certification,Operations,Achivements,Facilities,Category,Approved")] HospitalDetails hospitalDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospitalDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hospitalDetails);
        }

        // GET: HospitalDetails/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalDetails hospitalDetails = db.HospitalDetails.Find(id);
            if (hospitalDetails == null)
            {
                return HttpNotFound();
            }
            return View(hospitalDetails);
        }

        // POST: HospitalDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HospitalDetails hospitalDetails = db.HospitalDetails.Find(id);
            db.HospitalDetails.Remove(hospitalDetails);
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

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }

    }
}
