using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymManagement.Data;
using GymManagement.Models;
using System.Data.Entity;

namespace GymManagement.Controllers
{
    public class PaymentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Payment
        public ActionResult Index()
        {
           var memberPayments = db.tbl_payment.Include(u => u.Member).Select(p => new MemberPaymentViewModel
           {
			   MemberId = p.MemberId,
			   MemberName = p.Member.MemberName,
			   Phone = p.Member.Phone,
			   PaymentId = p.Id,
			   Fees = p.Fees,
			   AmountPaid = p.AmountPaid,
			   BalanceAmount = p.BalanceAmount

		   }).ToList();
            return View(memberPayments);
        }
        public ActionResult PaymentList()
        {
            List<Payment> objPayment = db.tbl_payment.ToList();
            return View(objPayment);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Payment objPayment)
        {
            db.tbl_payment.Add(objPayment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}