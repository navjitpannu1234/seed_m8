namespace SeedManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CropVarieties",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CropID = c.Int(nullable: false),
                        VarietyName = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Crops", t => t.CropID, cascadeDelete: true)
                .Index(t => t.CropID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CropVarieties", "CropID", "dbo.Crops");
            DropIndex("dbo.CropVarieties", new[] { "CropID" });
            DropTable("dbo.CropVarieties");
        }
    }
}
