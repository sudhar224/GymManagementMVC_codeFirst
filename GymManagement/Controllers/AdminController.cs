using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymManagement.Data;
using GymManagement.Models;

namespace GymManagement.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin
        public ActionResult Index()
        {
            List<Admin> objAdmin = db.admins.ToList();
            return View(objAdmin);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Admin objAdmin)
        {
            db.admins.Add(objAdmin);
            db.SaveChanges();
			return RedirectToAction("Index");
		}

        public ActionResult Edit(int id)
        {
            Admin objAdmin = db.admins.FirstOrDefault(u => u.Id == id);
            return View(objAdmin);
        }
        [HttpPost]
        public ActionResult Edit(Admin objAdmin)
        {
            db.admins.AddOrUpdate(objAdmin);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
           Admin objAdmin = db.admins.FirstOrDefault(u => u.Id == id);
            return View(objAdmin);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            Admin objAdmin = db.admins.FirstOrDefault(u => u.Id==id);
            db.admins.Remove(objAdmin);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Details(int id)
        {
            Admin objAdmin = db.admins.FirstOrDefault(u => u.Id ==id);
            return View(objAdmin);
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin objAdmin)
        {
            db.admins.Where(u => u.UserName == objAdmin.UserName && u.Password == objAdmin.Password);
            return RedirectToAction("Index");
        }
    }
}