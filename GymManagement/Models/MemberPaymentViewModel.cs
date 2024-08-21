using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymManagement.Models
{
	public class MemberPaymentViewModel
	{
		public int MemberId { get; set; }
		public string MemberName { get; set; }
		public string Phone { get; set; }
		public int PaymentId { get; set; }
		public int Fees { get; set; }
		public string AmountPaid { get; set; }
		public string BalanceAmount { get; set; }
	}
}