namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emp011 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Email", c => c.String());
            AddColumn("dbo.Employees", "BloodGroup", c => c.String());
            AddColumn("dbo.Employees", "DeptId", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Address");
            DropColumn("dbo.Employees", "DeptId");
            DropColumn("dbo.Employees", "BloodGroup");
            DropColumn("dbo.Employees", "Email");
        }
    }
}
