namespace JD.BusinessObjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "profileImagePath", c => c.String());
            AddColumn("dbo.Users", "profileImageName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "profileImageName");
            DropColumn("dbo.Users", "profileImagePath");
        }
    }
}
