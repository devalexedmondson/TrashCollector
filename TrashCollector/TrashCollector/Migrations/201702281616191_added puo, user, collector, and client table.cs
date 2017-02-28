namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpuousercollectorandclienttable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID_ID)
                .Index(t => t.UserID_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Amount_Due = c.Double(nullable: false),
                        Type = c.Int(nullable: false),
                        AddressID_AddressID = c.Int(),
                        Pick_Up_OptionsID_Pick_Up_OptionsID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.AddressID_AddressID)
                .ForeignKey("dbo.Pick_Up_Options", t => t.Pick_Up_OptionsID_Pick_Up_OptionsID)
                .Index(t => t.AddressID_AddressID)
                .Index(t => t.Pick_Up_OptionsID_Pick_Up_OptionsID);
            
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
                        Zip_ZipID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.Client_ID)
                .ForeignKey("dbo.Zips", t => t.Zip_ZipID)
                .Index(t => t.Client_ID)
                .Index(t => t.Zip_ZipID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Collectors", "Zip_ZipID", "dbo.Zips");
            DropForeignKey("dbo.Collectors", "Client_ID", "dbo.Clients");
            DropForeignKey("dbo.Clients", "UserID_ID", "dbo.Users");
            DropForeignKey("dbo.Users", "Pick_Up_OptionsID_Pick_Up_OptionsID", "dbo.Pick_Up_Options");
            DropForeignKey("dbo.Users", "AddressID_AddressID", "dbo.Addresses");
            DropIndex("dbo.Collectors", new[] { "Zip_ZipID" });
            DropIndex("dbo.Collectors", new[] { "Client_ID" });
            DropIndex("dbo.Users", new[] { "Pick_Up_OptionsID_Pick_Up_OptionsID" });
            DropIndex("dbo.Users", new[] { "AddressID_AddressID" });
            DropIndex("dbo.Clients", new[] { "UserID_ID" });
            DropTable("dbo.Collectors");
            DropTable("dbo.Users");
            DropTable("dbo.Clients");
        }
    }
}
