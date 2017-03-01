namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addinguser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "UserID_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Clients", new[] { "UserID_Id" });
            DropColumn("dbo.Clients", "UserID_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "UserID_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Clients", "UserID_Id");
            AddForeignKey("dbo.Clients", "UserID_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
