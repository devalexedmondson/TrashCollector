namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedtimeID : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Pick_Up_Options", "TimeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pick_Up_Options", "TimeID", c => c.Int(nullable: false));
        }
    }
}
