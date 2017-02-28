namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPickupoptions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pick_Up_Options",
                c => new
                    {
                        Pick_Up_OptionsID = c.Int(nullable: false, identity: true),
                        TimeID = c.Int(nullable: false),
                        Absent_TimeID = c.Int(),
                        Normal_TimeID = c.Int(),
                        Substitute_TimeID = c.Int(),
                    })
                .PrimaryKey(t => t.Pick_Up_OptionsID)
                .ForeignKey("dbo.Times", t => t.Absent_TimeID)
                .ForeignKey("dbo.Times", t => t.Normal_TimeID)
                .ForeignKey("dbo.Times", t => t.Substitute_TimeID)
                .Index(t => t.Absent_TimeID)
                .Index(t => t.Normal_TimeID)
                .Index(t => t.Substitute_TimeID);
            
            CreateTable(
                "dbo.Times",
                c => new
                    {
                        TimeID = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                        Time_Of_Day = c.String(),
                    })
                .PrimaryKey(t => t.TimeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pick_Up_Options", "Substitute_TimeID", "dbo.Times");
            DropForeignKey("dbo.Pick_Up_Options", "Normal_TimeID", "dbo.Times");
            DropForeignKey("dbo.Pick_Up_Options", "Absent_TimeID", "dbo.Times");
            DropIndex("dbo.Pick_Up_Options", new[] { "Substitute_TimeID" });
            DropIndex("dbo.Pick_Up_Options", new[] { "Normal_TimeID" });
            DropIndex("dbo.Pick_Up_Options", new[] { "Absent_TimeID" });
            DropTable("dbo.Times");
            DropTable("dbo.Pick_Up_Options");
        }
    }
}
