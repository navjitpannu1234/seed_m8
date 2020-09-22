namespace SeedManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CropRates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VarietyID = c.Int(nullable: false),
                        Rate = c.String(),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CropVariety_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CropVarieties", t => t.CropVariety_ID)
                .Index(t => t.CropVariety_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CropRates", "CropVariety_ID", "dbo.CropVarieties");
            DropIndex("dbo.CropRates", new[] { "CropVariety_ID" });
            DropTable("dbo.CropRates");
        }
    }
}
