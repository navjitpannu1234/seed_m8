namespace SeedManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankPayments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TransactionDate = c.DateTime(nullable: false),
                        TransactionNumber = c.String(),
                        AmountReceived = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BankPayments");
        }
    }
}
