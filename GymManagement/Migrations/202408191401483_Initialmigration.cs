namespace GymManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        TrainerId = c.Int(nullable: false, identity: true),
                        TrainerName = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        DOB = c.String(nullable: false),
                        Mobile = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Weight = c.String(nullable: false),
                        Height = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TrainerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trainers");
        }
    }
}
