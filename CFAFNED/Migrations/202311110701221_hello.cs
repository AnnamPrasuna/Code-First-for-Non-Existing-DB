namespace CFAFNED.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hello : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Employees");
            AddColumn("dbo.Employees", "EmployeeId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Employees", "EmployeeId");
            DropColumn("dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Employees");
            DropColumn("dbo.Employees", "EmployeeId");
            AddPrimaryKey("dbo.Employees", "Id");
        }
    }
}
