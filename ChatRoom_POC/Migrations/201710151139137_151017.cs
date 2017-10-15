namespace ChatRoom_POC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _151017 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Messages", "CreatedByID", "dbo.Users");
            DropIndex("dbo.Messages", new[] { "CreatedByID" });
            AlterColumn("dbo.Messages", "CreatedByID", c => c.Int());
            CreateIndex("dbo.Messages", "CreatedByID");
            AddForeignKey("dbo.Messages", "CreatedByID", "dbo.Users", "UserID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "CreatedByID", "dbo.Users");
            DropIndex("dbo.Messages", new[] { "CreatedByID" });
            AlterColumn("dbo.Messages", "CreatedByID", c => c.Int(nullable: false));
            CreateIndex("dbo.Messages", "CreatedByID");
            AddForeignKey("dbo.Messages", "CreatedByID", "dbo.Users", "UserID", cascadeDelete: true);
        }
    }
}
