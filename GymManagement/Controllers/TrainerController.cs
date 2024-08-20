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
    public class TrainerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Trainer
        public ActionResult Index()
        {
            var trainerobj = db.tbl_trainers.ToList();
            return View(trainerobj);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Trainer objTrainer)
        {
            db.tbl_trainers.Add(objTrainer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Trainer objTrainer = db.tbl_trainers.FirstOrDefault(u => u.TrainerId == id);

            return View(objTrainer);
        }
        [HttpPost]
        public ActionResult Edit(Trainer objTrainer)
        {
            db.tbl_trainers.AddOrUpdate(objTrainer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Trainer ObjTrainer = db.tbl_trainers.FirstOrDefault(u => u.TrainerId == id);
            
            return View(ObjTrainer);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            Trainer objTrainer = db.tbl_trainers.FirstOrDefault(u => u.TrainerId == id);
            db.tbl_trainers.Remove(objTrainer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Trainer objTrainer = db.tbl_trainers.FirstOrDefault(u => u.TrainerId == id);
            return View(objTrainer);
        }
    }
}