namespace GymManagement.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using GymManagement.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<GymManagement.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GymManagement.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.tbl_trainers.AddOrUpdate(
                t => t.TrainerId,
                new Trainer
                {
                    TrainerId =1,
                    TrainerName = "sudhar",
                    Gender = "Male",
                    DOB = "20.05.94",
                    Mobile = "7876778",
                    Address ="uthukuli",
                    Weight = "64",
                    Height= "178cm"

                }
                );
        }
    }
}
