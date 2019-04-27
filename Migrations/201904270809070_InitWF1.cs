namespace WF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitWF1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Name");
        }
    }
}
