namespace ApplicationMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationV3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "AuthorName", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "Site", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "Body", c => c.String(nullable: false));
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Posts", "AuthorName", c => c.String(nullable: false));
            AlterColumn("dbo.Posts", "SiteAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Posts", "Body", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Body", c => c.String());
            AlterColumn("dbo.Posts", "SiteAddress", c => c.String());
            AlterColumn("dbo.Posts", "AuthorName", c => c.String());
            AlterColumn("dbo.Posts", "Title", c => c.String());
            AlterColumn("dbo.Comments", "Body", c => c.String());
            AlterColumn("dbo.Comments", "Site", c => c.String());
            AlterColumn("dbo.Comments", "AuthorName", c => c.String());
            AlterColumn("dbo.Comments", "Title", c => c.String());
        }
    }
}
