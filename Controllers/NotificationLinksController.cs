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
    public class NotificationLinksController : Controller
    {
        private DataContext db = new DataContext();

        // GET: NotificationLinks
        public ActionResult Index()
        {
            return View(db.notificationLinks.ToList());
        }

        // GET: NotificationLinks/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotificationLink notificationLink = db.notificationLinks.Find(id);
            if (notificationLink == null)
            {
                return HttpNotFound();
            }
            return View(notificationLink);
        }

        // GET: NotificationLinks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotificationLinks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Hospital_id,Hospial_Name,Approvalstatus")] NotificationLink notificationLink)
        {
            if (ModelState.IsValid)
            {
                db.notificationLinks.Add(notificationLink);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notificationLink);
        }

        // GET: NotificationLinks/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotificationLink notificationLink = db.notificationLinks.Find(id);
            if (notificationLink == null)
            {
                return HttpNotFound();
            }
            return View(notificationLink);
        }

        // POST: NotificationLinks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Hospital_id,Hospial_Name,Approvalstatus")] NotificationLink notificationLink)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notificationLink).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notificationLink);
        }

        // GET: NotificationLinks/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotificationLink notificationLink = db.notificationLinks.Find(id);
            if (notificationLink == null)
            {
                return HttpNotFound();
            }
            return View(notificationLink);
        }

        // POST: NotificationLinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NotificationLink notificationLink = db.notificationLinks.Find(id);
            db.notificationLinks.Remove(notificationLink);
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
