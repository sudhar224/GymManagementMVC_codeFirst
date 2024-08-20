using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GymManagement.Models
{
	public class Trainer
	{
		[Key]
		public int TrainerId { get; set; }
		[Required]
		public string TrainerName { get; set; }
		[Required]	
		public string Gender { get; set; }
		[Required]
		public string DOB { get; set; }
		[Required]
		public string Mobile { get; set; }
		[Required]	
		public string Address { get; set;}
		[Required]
		public string Weight { get; set;}
		[Required]
		public string Height { get; set;}
	}
}