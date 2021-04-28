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
    public class UsersController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Users
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,FirstName,LastName,DoB,Genders,ContactNumber,Email,Password,Category")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,FirstName,LastName,DoB,Genders,ContactNumber,Email,Password,Category")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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

        public ActionResult Login()
        {
            return View();

        }

        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
                using (DataContext db = new DataContext())
                {
                    var obj = db.Users.Where(u => u.UserId.Equals(user.UserId) && u.Password.Equals(user.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["userid"] = obj.UserId.ToString();
                        Session["name"] = obj.FirstName.ToString();
                        return RedirectToAction("UserDash");
                    }
                }
        return View(user);
        }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            using (DataContext db = new DataContext())
            {
                var obj = db.Users.Where(u => u.UserId.Equals(user.UserId) && u.Password.Equals(user.Password)).FirstOrDefault();
                if (obj != null)
                {
                    /*if(obj.UserId.Substring(0, 3).Equals("PAT"))
                    {
                        Session["user_id"] = obj.UserId.ToString();
                        Session["name"] = obj.FirstName.ToString();
                        return RedirectToAction("Index","User");
                    }
                    else if (obj.UserId.Substring(0, 3).Equals("DOC"))
                    {
                        Session["doctor_id"] = obj.UserId.ToString();
                        Session["name"] = obj.FirstName.ToString();
                        return RedirectToAction("Index","Doctor");
                    }*/
                    if ((int)(obj.Category) == 0)
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                        Session["userid"] = obj.UserId.ToString();
                        Session["name"] = obj.FirstName.ToString();
                        return RedirectToAction("DoctorDash", "Doctors");
                    }
            }
            return View(user);
        }

        public ActionResult UserDash()
        {
            if (Session["userid"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }


    }
}
