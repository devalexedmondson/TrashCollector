namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcollectortable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Collectors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Type = c.Int(nullable: false),
                        Work_Day = c.String(),
                        Client_ID = c.Int(),
                        Zip_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.Client_ID)
                .ForeignKey("dbo.Zips", t => t.Zip_ID)
                .Index(t => t.Client_ID)
                .Index(t => t.Zip_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Collectors", "Zip_ID", "dbo.Zips");
            DropForeignKey("dbo.Collectors", "Client_ID", "dbo.Clients");
            DropIndex("dbo.Collectors", new[] { "Zip_ID" });
            DropIndex("dbo.Collectors", new[] { "Client_ID" });
            DropTable("dbo.Collectors");
        }
    }
}
