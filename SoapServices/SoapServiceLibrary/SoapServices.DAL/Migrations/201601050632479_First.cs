namespace SoapServices.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StreetLine1 = c.String(unicode: false),
                        StreetLine2 = c.String(unicode: false),
                        City = c.String(unicode: false),
                        State = c.String(unicode: false),
                        Country = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrimaryContactNumber = c.String(nullable: false, unicode: false),
                        SecondaryContactNumber = c.String(unicode: false),
                        EmailId = c.String(nullable: false, unicode: false),
                        SkypeId = c.String(unicode: false),
                        LinkedInId = c.String(unicode: false),
                        FacebookId = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(unicode: false),
                        CourseContents = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, unicode: false),
                        FathersName = c.String(nullable: false, unicode: false),
                        ContactId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.ContactInfo", t => t.ContactId, cascadeDelete: true)
                .Index(t => t.ContactId)
                .Index(t => t.AddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "ContactId", "dbo.ContactInfo");
            DropForeignKey("dbo.Student", "AddressId", "dbo.Address");
            DropIndex("dbo.Student", new[] { "AddressId" });
            DropIndex("dbo.Student", new[] { "ContactId" });
            DropTable("dbo.Student");
            DropTable("dbo.Course");
            DropTable("dbo.ContactInfo");
            DropTable("dbo.Address");
        }
    }
}
