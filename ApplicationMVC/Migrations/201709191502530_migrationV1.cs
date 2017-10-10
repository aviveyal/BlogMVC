namespace ApplicationMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationV1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "AuthorName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "AuthorName", c => c.Int(nullable: false));
        }
    }
}
