namespace JD.BusinessObjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JDfirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        type = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        createdBy = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        iP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        countryId = c.Int(nullable: false),
                        stateId = c.Int(nullable: false),
                        cityName = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        createdBy = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        iP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        createdBy = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        iP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FranchiseLocations",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        countryId = c.Int(nullable: false),
                        stateId = c.Int(nullable: false),
                        cityId = c.Int(nullable: false),
                        location = c.Int(nullable: false),
                        latitude = c.String(),
                        longitude = c.String(),
                        pinCode = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        createdBy = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        iP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Franchises",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        brandName = c.String(),
                        franchiseType = c.Int(nullable: false),
                        imagePath = c.String(),
                        imageName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        createdBy = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        iP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FranchiseTypes",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        type = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        createdBy = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        iP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        countryId = c.Int(nullable: false),
                        state = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        createdBy = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        iP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        name = c.String(),
                        email = c.String(),
                        phone = c.String(),
                        password = c.String(),
                        address = c.String(),
                        permanentAddress = c.String(),
                        userTypeId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        createdBy = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        iP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.States");
            DropTable("dbo.FranchiseTypes");
            DropTable("dbo.Franchises");
            DropTable("dbo.FranchiseLocations");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.UserTypes");
        }
    }
}
