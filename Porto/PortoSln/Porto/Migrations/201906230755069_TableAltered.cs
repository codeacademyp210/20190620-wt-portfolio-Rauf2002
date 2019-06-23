namespace Porto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableAltered : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admin", "Name", c => c.String());
            AddColumn("dbo.Admin", "Surname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admin", "Surname");
            DropColumn("dbo.Admin", "Name");
        }
    }
}
