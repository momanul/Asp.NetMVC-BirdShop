namespace BirdShopMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class birds : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Birds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BirdName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DealersID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dealers", t => t.DealersID, cascadeDelete: true)
                .Index(t => t.DealersID);
            
            CreateTable(
                "dbo.Dealers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DealerName = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserPassword = c.String(),
                        UserRole = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Birds", "DealersID", "dbo.Dealers");
            DropIndex("dbo.Birds", new[] { "DealersID" });
            DropTable("dbo.Users");
            DropTable("dbo.Dealers");
            DropTable("dbo.Birds");
        }
    }
}
