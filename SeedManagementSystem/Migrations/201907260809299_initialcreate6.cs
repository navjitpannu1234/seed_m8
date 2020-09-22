namespace SeedManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SeedSellings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        CropVarietyID = c.Int(nullable: false),
                        NoofBags = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CropVarieties", t => t.CropVarietyID, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.CropVarietyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SeedSellings", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.SeedSellings", "CropVarietyID", "dbo.CropVarieties");
            DropIndex("dbo.SeedSellings", new[] { "CropVarietyID" });
            DropIndex("dbo.SeedSellings", new[] { "CustomerID" });
            DropTable("dbo.SeedSellings");
        }
    }
}
