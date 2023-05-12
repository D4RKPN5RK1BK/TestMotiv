namespace TestMotiv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequestReasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubscriberRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Phone = c.String(),
                        CityName = c.String(),
                        RegionName = c.String(),
                        CountryName = c.String(),
                        RequestReasonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RequestReasons", t => t.RequestReasonId, cascadeDelete: true)
                .Index(t => t.RequestReasonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubscriberRequests", "RequestReasonId", "dbo.RequestReasons");
            DropIndex("dbo.SubscriberRequests", new[] { "RequestReasonId" });
            DropTable("dbo.SubscriberRequests");
            DropTable("dbo.RequestReasons");
        }
    }
}
