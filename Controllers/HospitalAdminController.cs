using OneStopMiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneStopMiniProject.Controllers
{
    public class HospitalAdminController : Controller
    {
        DataContext db = new DataContext();
        // GET: HospitalAdmin
        public ActionResult Index()
        {
            return View(db.HospitalAdmins.ToList());
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(HospitalAdmin hospitalAdmin)
        {

            if (ModelState.IsValid)
            {
                db.HospitalAdmins.Add(hospitalAdmin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Some Error occured");
            }
            return View(hospitalAdmin);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(HospitalAdmin hospitalAdmin)
        {
            
                using (DataContext db = new DataContext())
                {
                    var obj = db.HospitalAdmins.Where(u => u.email.Equals(hospitalAdmin.email) && u.hadmin_password.Equals(hospitalAdmin.hadmin_password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["hospitaladmin_id"] = obj.hospitaladmin_id.ToString();
                        Session["name"] = obj.hadmin_name.ToString();
                        return RedirectToAction("HospitalAdminDash", "HospitalAdmin");
                    }
                }
        return View(hospitalAdmin);
        }

        public ActionResult HospitalAdminDash()
        {
            if (Session["hospitaladmin_id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login","HospitalAdmin");
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "HospitalAdmin","HospitalAdmin");
        }

    }
}