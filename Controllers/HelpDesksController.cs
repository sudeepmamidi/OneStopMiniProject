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
    public class HelpDesksController : Controller
    {
        private DataContext db = new DataContext();

        // GET: HelpDesks
        public ActionResult Index()
        {
            return View(db.HelpDesks.ToList());
        }

        // GET: HelpDesks/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HelpDesk helpDesk = db.HelpDesks.Find(id);
            if (helpDesk == null)
            {
                return HttpNotFound();
            }
            return View(helpDesk);
        }

        // GET: HelpDesks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HelpDesks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Description,CreatedOn")] HelpDesk helpDesk)
        {
            if (ModelState.IsValid)
            {
                db.HelpDesks.Add(helpDesk);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(helpDesk);
        }

        // GET: HelpDesks/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HelpDesk helpDesk = db.HelpDesks.Find(id);
            if (helpDesk == null)
            {
                return HttpNotFound();
            }
            return View(helpDesk);
        }

        // POST: HelpDesks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Description,CreatedOn")] HelpDesk helpDesk)
        {
            if (ModelState.IsValid)
            {
                db.Entry(helpDesk).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(helpDesk);
        }

        // GET: HelpDesks/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HelpDesk helpDesk = db.HelpDesks.Find(id);
            if (helpDesk == null)
            {
                return HttpNotFound();
            }
            return View(helpDesk);
        }

        // POST: HelpDesks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HelpDesk helpDesk = db.HelpDesks.Find(id);
            db.HelpDesks.Remove(helpDesk);
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
