namespace Hff.JobTracking.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseChange : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.UserWorks", new[] { "WorkId", "UserId" });
            DropIndex("dbo.UserRoles", new[] { "UserId", "RoleId" });
            CreateIndex("dbo.UserWorks", "UserId");
            CreateIndex("dbo.UserWorks", "WorkId");
            CreateIndex("dbo.UserRoles", "UserId");
            CreateIndex("dbo.UserRoles", "RoleId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.UserRoles", new[] { "RoleId" });
            DropIndex("dbo.UserRoles", new[] { "UserId" });
            DropIndex("dbo.UserWorks", new[] { "WorkId" });
            DropIndex("dbo.UserWorks", new[] { "UserId" });
            CreateIndex("dbo.UserRoles", new[] { "UserId", "RoleId" }, unique: true);
            CreateIndex("dbo.UserWorks", new[] { "WorkId", "UserId" }, unique: true);
        }
    }
}
