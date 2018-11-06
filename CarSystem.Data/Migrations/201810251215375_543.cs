namespace CarSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _543 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Cars", "User_Id");
            AddForeignKey("dbo.Cars", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Cars", new[] { "User_Id" });
            DropColumn("dbo.Cars", "User_Id");
            DropColumn("dbo.Cars", "UserId");
        }
    }
}
