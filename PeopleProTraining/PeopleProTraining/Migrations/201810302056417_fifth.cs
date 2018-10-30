namespace PeopleProTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Faculties", "Department_ID", "dbo.Departments");
            DropIndex("dbo.Faculties", new[] { "Department_ID" });
            AddColumn("dbo.Faculties", "Department_ID1", c => c.Int());
            AlterColumn("dbo.Faculties", "Department_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Faculties", "Department_ID1");
            AddForeignKey("dbo.Faculties", "Department_ID1", "dbo.Departments", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faculties", "Department_ID1", "dbo.Departments");
            DropIndex("dbo.Faculties", new[] { "Department_ID1" });
            AlterColumn("dbo.Faculties", "Department_ID", c => c.Int());
            DropColumn("dbo.Faculties", "Department_ID1");
            CreateIndex("dbo.Faculties", "Department_ID");
            AddForeignKey("dbo.Faculties", "Department_ID", "dbo.Departments", "ID");
        }
    }
}
