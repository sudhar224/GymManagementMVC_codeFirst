using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GymManagement.Models
{
	public class Member
	{
		[Key]
		public int MemberId { get; set; }
		[Required]
		public string MemberName { get; set; }
		[Required]
		public int TrainerId { get; set; }
		[Required]
		public string Gender { get; set; }
		[Required]
		public string Age { get; set; }
		[Required]
		public string Phone { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		public DateTime DOJ { get; set; }
		[Required]
		public string WorkoutTime { get; set; }
		public virtual ICollection<Payment> Payments { get; set; }

	}
}