namespace SOLIDPrinciple.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KeyExtensions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequesterId = c.Int(nullable: false),
                        KeyRequestId = c.Int(nullable: false),
                        ExtenTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KeyReconciles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequesterId = c.Int(nullable: false),
                        KeyRequestId = c.Int(nullable: false),
                        ReconcilationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KeyRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequesterId = c.Int(nullable: false),
                        KeyId = c.Int(nullable: false),
                        KeyType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LeaveOfAbsences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Ammount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Payments");
            DropTable("dbo.LeaveOfAbsences");
            DropTable("dbo.KeyRequests");
            DropTable("dbo.KeyReconciles");
            DropTable("dbo.KeyExtensions");
        }
    }
}
