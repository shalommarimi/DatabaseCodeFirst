namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class managements : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        PK_CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        FK_ProvinceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PK_CityId)
                .ForeignKey("dbo.Provinces", t => t.FK_ProvinceId, cascadeDelete: true)
                .Index(t => t.FK_ProvinceId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        PK_ProvinceId = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(),
                    })
                .PrimaryKey(t => t.PK_ProvinceId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        PK_DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        DepartmentDescription = c.String(),
                    })
                .PrimaryKey(t => t.PK_DepartmentId);
            
            CreateTable(
                "dbo._User",
                c => new
                    {
                        PK_UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        MiddleName = c.String(),
                        LastName = c.String(nullable: false, maxLength: 100),
                        EmailAddress = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 300),
                        IsApproved = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        FK_DepartmentId = c.Int(nullable: false),
                        FK_GenderId = c.Int(nullable: false),
                        FK_UserTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PK_UserId)
                .ForeignKey("dbo.Departments", t => t.FK_DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.FK_GenderId, cascadeDelete: true)
                .ForeignKey("dbo.UserTypes", t => t.FK_UserTypeId, cascadeDelete: true)
                .Index(t => t.FK_DepartmentId)
                .Index(t => t.FK_GenderId)
                .Index(t => t.FK_UserTypeId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        PK_GenderId = c.Int(nullable: false, identity: true),
                        GenderValue = c.String(),
                    })
                .PrimaryKey(t => t.PK_GenderId);
            
            CreateTable(
                "dbo.Physical_Address",
                c => new
                    {
                        PK_PhysicalAddessId = c.Int(nullable: false, identity: true),
                        StreetLine1 = c.String(nullable: false, maxLength: 100),
                        StreetLine2 = c.String(),
                        StreetLine3 = c.String(),
                        FK_UserId = c.Int(nullable: false),
                        FK_SuburbId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PK_PhysicalAddessId)
                .ForeignKey("dbo.Suburbs", t => t.FK_SuburbId, cascadeDelete: true)
                .ForeignKey("dbo._User", t => t.FK_UserId, cascadeDelete: true)
                .Index(t => t.FK_UserId)
                .Index(t => t.FK_SuburbId);
            
            CreateTable(
                "dbo.Suburbs",
                c => new
                    {
                        PK_SuburbId = c.Int(nullable: false, identity: true),
                        SuburbName = c.String(),
                        FK_CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PK_SuburbId)
                .ForeignKey("dbo.Cities", t => t.FK_CityId, cascadeDelete: true)
                .Index(t => t.FK_CityId);
            
            CreateTable(
                "dbo.Postal_Address",
                c => new
                    {
                        PK_PostalAddressId = c.Int(nullable: false, identity: true),
                        AddressLine1 = c.String(nullable: false, maxLength: 100),
                        AddressLine2 = c.String(),
                        AddressLine3 = c.String(),
                        FK_UserId = c.Int(nullable: false),
                        FK_SuburbId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PK_PostalAddressId)
                .ForeignKey("dbo.Suburbs", t => t.FK_SuburbId, cascadeDelete: true)
                .ForeignKey("dbo._User", t => t.FK_UserId, cascadeDelete: true)
                .Index(t => t.FK_UserId)
                .Index(t => t.FK_SuburbId);
            
            CreateTable(
                "dbo.Postal_Code",
                c => new
                    {
                        PK_PostalCodeId = c.Int(nullable: false, identity: true),
                        PostalCodeNumber = c.String(),
                        FK_SuburbId_PK_SuburbId = c.Int(),
                    })
                .PrimaryKey(t => t.PK_PostalCodeId)
                .ForeignKey("dbo.Suburbs", t => t.FK_SuburbId_PK_SuburbId)
                .Index(t => t.FK_SuburbId_PK_SuburbId);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        UserTypeId = c.Int(nullable: false, identity: true),
                        UserTypeName = c.String(),
                    })
                .PrimaryKey(t => t.UserTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo._User", "FK_UserTypeId", "dbo.UserTypes");
            DropForeignKey("dbo.Physical_Address", "FK_UserId", "dbo._User");
            DropForeignKey("dbo.Postal_Code", "FK_SuburbId_PK_SuburbId", "dbo.Suburbs");
            DropForeignKey("dbo.Postal_Address", "FK_UserId", "dbo._User");
            DropForeignKey("dbo.Postal_Address", "FK_SuburbId", "dbo.Suburbs");
            DropForeignKey("dbo.Physical_Address", "FK_SuburbId", "dbo.Suburbs");
            DropForeignKey("dbo.Suburbs", "FK_CityId", "dbo.Cities");
            DropForeignKey("dbo._User", "FK_GenderId", "dbo.Genders");
            DropForeignKey("dbo._User", "FK_DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Cities", "FK_ProvinceId", "dbo.Provinces");
            DropIndex("dbo.Postal_Code", new[] { "FK_SuburbId_PK_SuburbId" });
            DropIndex("dbo.Postal_Address", new[] { "FK_SuburbId" });
            DropIndex("dbo.Postal_Address", new[] { "FK_UserId" });
            DropIndex("dbo.Suburbs", new[] { "FK_CityId" });
            DropIndex("dbo.Physical_Address", new[] { "FK_SuburbId" });
            DropIndex("dbo.Physical_Address", new[] { "FK_UserId" });
            DropIndex("dbo._User", new[] { "FK_UserTypeId" });
            DropIndex("dbo._User", new[] { "FK_GenderId" });
            DropIndex("dbo._User", new[] { "FK_DepartmentId" });
            DropIndex("dbo.Cities", new[] { "FK_ProvinceId" });
            DropTable("dbo.UserTypes");
            DropTable("dbo.Postal_Code");
            DropTable("dbo.Postal_Address");
            DropTable("dbo.Suburbs");
            DropTable("dbo.Physical_Address");
            DropTable("dbo.Genders");
            DropTable("dbo._User");
            DropTable("dbo.Departments");
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
        }
    }
}
