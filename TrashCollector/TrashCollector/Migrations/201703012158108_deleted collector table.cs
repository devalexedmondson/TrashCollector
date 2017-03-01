namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedcollectortable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Collectors", "Client_ID", "dbo.Clients");
            DropForeignKey("dbo.Collectors", "Zip_ID", "dbo.Zips");
            DropIndex("dbo.Collectors", new[] { "Client_ID" });
            DropIndex("dbo.Collectors", new[] { "Zip_ID" });
            DropTable("dbo.Collectors");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Collectors", "Zip_ID");
            CreateIndex("dbo.Collectors", "Client_ID");
            AddForeignKey("dbo.Collectors", "Zip_ID", "dbo.Zips", "ID");
            AddForeignKey("dbo.Collectors", "Client_ID", "dbo.Clients", "ID");
        }
    }
}
