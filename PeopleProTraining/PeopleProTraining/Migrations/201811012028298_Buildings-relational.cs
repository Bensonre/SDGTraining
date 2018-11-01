namespace PeopleProTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Buildingsrelational : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buildings", "Department_Name", c => c.String());
            AddColumn("dbo.Buildings", "Department_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Buildings", "Department_ID1", c => c.Int());
            CreateIndex("dbo.Buildings", "Department_ID1");
            AddForeignKey("dbo.Buildings", "Department_ID1", "dbo.Departments", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buildings", "Department_ID1", "dbo.Departments");
            DropIndex("dbo.Buildings", new[] { "Department_ID1" });
            DropColumn("dbo.Buildings", "Department_ID1");
            DropColumn("dbo.Buildings", "Department_ID");
            DropColumn("dbo.Buildings", "Department_Name");
        }
    }
}
