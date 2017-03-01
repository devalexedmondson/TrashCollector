namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFKtoUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Address_ID_ID", c => c.Int());
            AddColumn("dbo.AspNetUsers", "PickUpOptionsID_ID", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Address_ID_ID");
            CreateIndex("dbo.AspNetUsers", "PickUpOptionsID_ID");
            AddForeignKey("dbo.AspNetUsers", "Address_ID_ID", "dbo.Addresses", "ID");
            AddForeignKey("dbo.AspNetUsers", "PickUpOptionsID_ID", "dbo.Pick_Up_Options", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "PickUpOptionsID_ID", "dbo.Pick_Up_Options");
            DropForeignKey("dbo.AspNetUsers", "Address_ID_ID", "dbo.Addresses");
            DropIndex("dbo.AspNetUsers", new[] { "PickUpOptionsID_ID" });
            DropIndex("dbo.AspNetUsers", new[] { "Address_ID_ID" });
            DropColumn("dbo.AspNetUsers", "PickUpOptionsID_ID");
            DropColumn("dbo.AspNetUsers", "Address_ID_ID");
        }
    }
}
