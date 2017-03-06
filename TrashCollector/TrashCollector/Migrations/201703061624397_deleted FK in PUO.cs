namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedFKinPUO : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pick_Up_Options", "TimeID", "dbo.Times");
            DropIndex("dbo.Pick_Up_Options", new[] { "TimeID" });
            DropTable("dbo.Times");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Times",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Pick_Up_Options", "TimeID");
            AddForeignKey("dbo.Pick_Up_Options", "TimeID", "dbo.Times", "ID", cascadeDelete: true);
        }
    }
}
