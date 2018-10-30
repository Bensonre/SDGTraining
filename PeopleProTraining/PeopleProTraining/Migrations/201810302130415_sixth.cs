namespace PeopleProTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sixth : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Faculties", new[] { "Department_ID1" });
            DropColumn("dbo.Faculties", "Department_ID");
            RenameColumn(table: "dbo.Faculties", name: "Department_ID1", newName: "Department_ID");
            AddColumn("dbo.Faculties", "Department_Name", c => c.Int(nullable: false));
            AlterColumn("dbo.Faculties", "Department_ID", c => c.Int());
            CreateIndex("dbo.Faculties", "Department_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Faculties", new[] { "Department_ID" });
            AlterColumn("dbo.Faculties", "Department_ID", c => c.Int(nullable: false));
            DropColumn("dbo.Faculties", "Department_Name");
            RenameColumn(table: "dbo.Faculties", name: "Department_ID", newName: "Department_ID1");
            AddColumn("dbo.Faculties", "Department_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Faculties", "Department_ID1");
        }
    }
}
