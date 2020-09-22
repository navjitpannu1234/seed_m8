namespace SeedManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CropVarietyID = c.Int(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NoofBags = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CropVarieties", t => t.CropVarietyID, cascadeDelete: true)
                .Index(t => t.CropVarietyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stores", "CropVarietyID", "dbo.CropVarieties");
            DropIndex("dbo.Stores", new[] { "CropVarietyID" });
            DropTable("dbo.Stores");
        }
    }
}
