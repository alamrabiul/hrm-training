namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emp01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeCode = c.String(maxLength: 10),
                        FullName = c.String(),
                        NickName = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        DesignationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Designations", t => t.DesignationId, cascadeDelete: true)
                .Index(t => t.DesignationId);
            
            AddColumn("dbo.Sections", "SectionCode", c => c.String());
            AddColumn("dbo.Sections", "SectionName", c => c.String(maxLength: 150));
            DropColumn("dbo.Sections", "CreateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sections", "CreateDate", c => c.String());
            DropForeignKey("dbo.Employees", "DesignationId", "dbo.Designations");
            DropIndex("dbo.Employees", new[] { "DesignationId" });
            DropColumn("dbo.Sections", "SectionName");
            DropColumn("dbo.Sections", "SectionCode");
            DropTable("dbo.Employees");
        }
    }
}
