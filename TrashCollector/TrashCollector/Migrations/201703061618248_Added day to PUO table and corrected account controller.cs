namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddeddaytoPUOtableandcorrectedaccountcontroller : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pick_Up_Options", "Day", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pick_Up_Options", "Day");
        }
    }
}
