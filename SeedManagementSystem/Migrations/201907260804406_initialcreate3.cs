namespace SeedManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CropRates", "CropVariety_ID", "dbo.CropVarieties");
            DropIndex("dbo.CropRates", new[] { "CropVariety_ID" });
            RenameColumn(table: "dbo.CropRates", name: "CropVariety_ID", newName: "CropVarietyID");
            AlterColumn("dbo.CropRates", "CropVarietyID", c => c.Int(nullable: false));
            CreateIndex("dbo.CropRates", "CropVarietyID");
            AddForeignKey("dbo.CropRates", "CropVarietyID", "dbo.CropVarieties", "ID", cascadeDelete: true);
            DropColumn("dbo.CropRates", "VarietyID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CropRates", "VarietyID", c => c.Int(nullable: false));
            DropForeignKey("dbo.CropRates", "CropVarietyID", "dbo.CropVarieties");
            DropIndex("dbo.CropRates", new[] { "CropVarietyID" });
            AlterColumn("dbo.CropRates", "CropVarietyID", c => c.Int());
            RenameColumn(table: "dbo.CropRates", name: "CropVarietyID", newName: "CropVariety_ID");
            CreateIndex("dbo.CropRates", "CropVariety_ID");
            AddForeignKey("dbo.CropRates", "CropVariety_ID", "dbo.CropVarieties", "ID");
        }
    }
}
