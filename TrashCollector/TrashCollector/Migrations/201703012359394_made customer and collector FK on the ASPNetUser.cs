namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madecustomerandcollectorFKontheASPNetUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Collectors", "Client_ID", "dbo.Clients");
            DropForeignKey("dbo.AspNetUsers", "Address_ID_ID", "dbo.Addresses");
            DropForeignKey("dbo.AspNetUsers", "PickUpOptionsID_ID", "dbo.Pick_Up_Options");
            DropIndex("dbo.Collectors", new[] { "Client_ID" });
            DropIndex("dbo.AspNetUsers", new[] { "Address_ID_ID" });
            DropIndex("dbo.AspNetUsers", new[] { "PickUpOptionsID_ID" });
            RenameColumn(table: "dbo.Collectors", name: "Zip_ID", newName: "Zip_ID_ID");
            RenameIndex(table: "dbo.Collectors", name: "IX_Zip_ID", newName: "IX_Zip_ID_ID");
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Address_ID_ID = c.Int(),
                        PickUpOptionsID_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.Address_ID_ID)
                .ForeignKey("dbo.Pick_Up_Options", t => t.PickUpOptionsID_ID)
                .Index(t => t.Address_ID_ID)
                .Index(t => t.PickUpOptionsID_ID);
            
            AddColumn("dbo.AspNetUsers", "CollectorInfo_ID", c => c.Int());
            AddColumn("dbo.AspNetUsers", "CustomerInfo_ID", c => c.String(maxLength: 128));
            CreateIndex("dbo.AspNetUsers", "CollectorInfo_ID");
            CreateIndex("dbo.AspNetUsers", "CustomerInfo_ID");
            AddForeignKey("dbo.AspNetUsers", "CollectorInfo_ID", "dbo.Collectors", "ID");
            AddForeignKey("dbo.AspNetUsers", "CustomerInfo_ID", "dbo.Customers", "ID");
            DropColumn("dbo.Collectors", "Password");
            DropColumn("dbo.Collectors", "Type");
            DropColumn("dbo.Collectors", "Work_Day");
            DropColumn("dbo.Collectors", "Client_ID");
            DropColumn("dbo.AspNetUsers", "Address_ID_ID");
            DropColumn("dbo.AspNetUsers", "PickUpOptionsID_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "PickUpOptionsID_ID", c => c.Int());
            AddColumn("dbo.AspNetUsers", "Address_ID_ID", c => c.Int());
            AddColumn("dbo.Collectors", "Client_ID", c => c.Int());
            AddColumn("dbo.Collectors", "Work_Day", c => c.String());
            AddColumn("dbo.Collectors", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Collectors", "Password", c => c.String());
            DropForeignKey("dbo.AspNetUsers", "CustomerInfo_ID", "dbo.Customers");
            DropForeignKey("dbo.Customers", "PickUpOptionsID_ID", "dbo.Pick_Up_Options");
            DropForeignKey("dbo.Customers", "Address_ID_ID", "dbo.Addresses");
            DropForeignKey("dbo.AspNetUsers", "CollectorInfo_ID", "dbo.Collectors");
            DropIndex("dbo.Customers", new[] { "PickUpOptionsID_ID" });
            DropIndex("dbo.Customers", new[] { "Address_ID_ID" });
            DropIndex("dbo.AspNetUsers", new[] { "CustomerInfo_ID" });
            DropIndex("dbo.AspNetUsers", new[] { "CollectorInfo_ID" });
            DropColumn("dbo.AspNetUsers", "CustomerInfo_ID");
            DropColumn("dbo.AspNetUsers", "CollectorInfo_ID");
            DropTable("dbo.Customers");
            RenameIndex(table: "dbo.Collectors", name: "IX_Zip_ID_ID", newName: "IX_Zip_ID");
            RenameColumn(table: "dbo.Collectors", name: "Zip_ID_ID", newName: "Zip_ID");
            CreateIndex("dbo.AspNetUsers", "PickUpOptionsID_ID");
            CreateIndex("dbo.AspNetUsers", "Address_ID_ID");
            CreateIndex("dbo.Collectors", "Client_ID");
            AddForeignKey("dbo.AspNetUsers", "PickUpOptionsID_ID", "dbo.Pick_Up_Options", "ID");
            AddForeignKey("dbo.AspNetUsers", "Address_ID_ID", "dbo.Addresses", "ID");
            AddForeignKey("dbo.Collectors", "Client_ID", "dbo.Clients", "ID");
        }
    }
}
