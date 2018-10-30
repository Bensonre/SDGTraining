namespace PeopleProTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Faculties", "Department_ID", c => c.Int());
            CreateIndex("dbo.Faculties", "Department_ID");
            AddForeignKey("dbo.Faculties", "Department_ID", "dbo.Departments", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faculties", "Department_ID", "dbo.Departments");
            DropIndex("dbo.Faculties", new[] { "Department_ID" });
            DropColumn("dbo.Faculties", "Department_ID");
        }
    }
}
