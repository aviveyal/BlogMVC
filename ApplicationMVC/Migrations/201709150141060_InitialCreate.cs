namespace ApplicationMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        PostID = c.Int(nullable: false),
                        Title = c.String(),
                        AuthorName = c.Int(nullable: false),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AuthorName = c.String(),
                        SiteAddress = c.String(),
                        PublishDate = c.DateTime(nullable: false),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.PostID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "PostID", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "PostID" });
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
        }
    }
}
