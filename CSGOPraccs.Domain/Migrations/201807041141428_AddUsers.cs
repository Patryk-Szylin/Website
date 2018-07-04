namespace CSGOPraccs.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Praccs",
                c => new
                    {
                        PraccID = c.Int(nullable: false, identity: true),
                        Map = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PraccID)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Praccs", "UserId", "dbo.Users");
            DropIndex("dbo.Praccs", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Praccs");
        }
    }
}
