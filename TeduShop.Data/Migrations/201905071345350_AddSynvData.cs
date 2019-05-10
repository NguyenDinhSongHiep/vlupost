namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSynvData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SyncLogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(),
                        Quantity = c.Int(nullable: false),
                        LastTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SyncLogs");
        }
    }
}
