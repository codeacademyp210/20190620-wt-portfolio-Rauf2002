namespace Porto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Datetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Setting", "Birthday", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Setting", "Birthday", c => c.DateTime(nullable: false));
        }
    }
}
