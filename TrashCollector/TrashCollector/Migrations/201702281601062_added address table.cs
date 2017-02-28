namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedaddresstable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        Suite = c.String(),
                        CityName_CityID = c.Int(),
                        StateName_StateID = c.Int(),
                        Zip_ZipID = c.Int(),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.Cities", t => t.CityName_CityID)
                .ForeignKey("dbo.States", t => t.StateName_StateID)
                .ForeignKey("dbo.Zips", t => t.Zip_ZipID)
                .Index(t => t.CityName_CityID)
                .Index(t => t.StateName_StateID)
                .Index(t => t.Zip_ZipID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "Zip_ZipID", "dbo.Zips");
            DropForeignKey("dbo.Addresses", "StateName_StateID", "dbo.States");
            DropForeignKey("dbo.Addresses", "CityName_CityID", "dbo.Cities");
            DropIndex("dbo.Addresses", new[] { "Zip_ZipID" });
            DropIndex("dbo.Addresses", new[] { "StateName_StateID" });
            DropIndex("dbo.Addresses", new[] { "CityName_CityID" });
            DropTable("dbo.Addresses");
        }
    }
}
