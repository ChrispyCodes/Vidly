namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b285f3d2-d978-4a53-b042-680702a1d9a5', N'guest@vidly.com', 0, N'AAdyXZoYmsbIHb6tbP72ELu5zyRa2V0oLjsgTyn5xQkMyfJp7LYB2cDFdafoo1PZQg==', N'81a2b073-2695-495a-9724-14360abe1bc9', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd848ea36-e624-45cd-a4bc-e60e475cb054', N'admin@vidly.com', 0, N'AGeT3i4SjKzTZ57AAkRdZ/rYVDFqOuelmZY1dBEKKssWlDHquYSDHcScdryx5FbLgQ==', N'0c2d29f6-7462-49df-ba59-4e19b9e3cecc', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7a9f7faa-10e8-4ff1-9498-e170cbcedf4a', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd848ea36-e624-45cd-a4bc-e60e475cb054', N'7a9f7faa-10e8-4ff1-9498-e170cbcedf4a')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
