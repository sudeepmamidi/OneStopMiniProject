using OneStopMiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneStopMiniProject.Controllers
{
    public class AdminController : Controller
    {
        DataContext db = new DataContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Admins.ToList());
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Admin admin)
        {
            if (ModelState.IsValid)
            {
                db.Admins.Add(admin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Some Error occured");
            }
            return View(admin);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Admin admin)
        {
            if (ModelState.IsValid)
            {
                using(DataContext db = new DataContext())
                {
                    var obj = db.Admins.Where(u => u.admin_name.Equals(admin.admin_name) && u.password.Equals(admin.password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["admin_id"] = obj.admin_id.ToString();
                        Session["name"] = obj.admin_name.ToString();
                        return RedirectToAction("Loggedin");
                    }
                }
            }
            return View(admin);
        }

        public ActionResult Loggedin()
        {
            if (Session["admin_id"]!=null)
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