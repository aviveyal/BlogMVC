namespace ApplicationMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationV2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "Site", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "Site");
        }
    }
}
