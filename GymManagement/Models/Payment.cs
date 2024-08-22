using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GymManagement.Models
{
	public class Payment
	{
		[Key]
		public int Id { get; set; }

		public int MemberId { get; set; }

		[ForeignKey("MemberId")]
		public virtual Member Member { get; set; }

		[Required]
		public int Fees { get; set; }

		[Required]
		public string Month { get; set; }

		[Required]
		public string AmountPaid { get; set; }

		[Required]
		public string BalanceAmount { get; set; }
	}
}
