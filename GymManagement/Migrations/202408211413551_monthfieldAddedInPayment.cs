namespace GymManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class monthfieldAddedInPayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "Month", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payments", "Month");
        }
    }
}
