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
    public class MemberController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Member
        public ActionResult Index()
        {
            List<Member> objMember = db.tbl_members.ToList();
            return View(objMember);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Member objMember)
        {
            db.tbl_members.Add(objMember);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Member objMember = db.tbl_members.FirstOrDefault(u => u.MemberId == id);
            
            return View(objMember);
        }
        [HttpPost]
        public ActionResult Edit(Member objMember)
        {
            db.tbl_members.AddOrUpdate(objMember);
            db.SaveChanges();
            return View(objMember);
        }
        public ActionResult Delete(int id)
        {
            db.tbl_members.FirstOrDefault(u => u.MemberId == id);
            
            return View();
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            Member objMember = db.tbl_members.FirstOrDefault(u => u.MemberId == id);
            db.tbl_members.Remove(objMember);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Member objMember = db.tbl_members.FirstOrDefault(u => u.MemberId == id);
            return View(objMember);
           
        }
    }
}