using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using GymManagement.Models;

namespace GymManagement.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext() : base("DefaultConnection") 
		{

		}
		public DbSet<Trainer> tbl_trainers { get; set; }
		public DbSet<Member> tbl_members { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			
		}

	}
}