namespace GymManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentClassAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MemberId = c.Int(nullable: false),
                        Fees = c.Int(nullable: false),
                        AmountPaid = c.String(nullable: false),
                        BalanceAmount = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "MemberId", "dbo.Members");
            DropIndex("dbo.Payments", new[] { "MemberId" });
            DropTable("dbo.Payments");
        }
    }
}
