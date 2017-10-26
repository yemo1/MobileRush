namespace Mobilerush.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceHeaders",
                c => new
                    {
                        HeaderId = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        ServiceLabel = c.String(),
                        ProductName = c.String(),
                        Description = c.String(),
                        MenuCategory = c.String(),
                        MenuCategoryLabel = c.String(),
                        Category = c.String(),
                        CategoryLabel = c.String(),
                        ProductCode = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        ServiceUrl = c.String(),
                        ImageUrl = c.String(),
                        HomeCategory = c.String(),
                        HomeCategoryLabel = c.String(),
                    })
                .PrimaryKey(t => t.HeaderId);
            
            CreateTable(
                "dbo.ServiceRequests",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        MSISDN = c.String(),
                        TransactionId = c.Guid(nullable: false),
                        ClientIp = c.String(),
                        SourceChannel = c.String(),
                        HeaderEnabled = c.Boolean(nullable: false),
                        ServiceHeaderId = c.Int(nullable: false),
                        Timestamped = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RequestId);
            
            CreateTable(
                "dbo.ServiceResponses",
                c => new
                    {
                        ResponseId = c.Int(nullable: false, identity: true),
                        RequestId = c.Int(nullable: false),
                        StatusCode = c.String(),
                        Description = c.String(),
                        Timestamped = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ResponseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ServiceResponses");
            DropTable("dbo.ServiceRequests");
            DropTable("dbo.ServiceHeaders");
        }
    }
}
