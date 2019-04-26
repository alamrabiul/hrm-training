namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EMP02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "MobieNumber", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "DeptId");
            AddForeignKey("dbo.Employees", "DeptId", "dbo.Depts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DeptId", "dbo.Depts");
            DropIndex("dbo.Employees", new[] { "DeptId" });
            DropColumn("dbo.Employees", "MobieNumber");
        }
    }
}
