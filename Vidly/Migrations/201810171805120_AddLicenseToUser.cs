namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLicenseToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "License", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "License");
        }
    }
}
