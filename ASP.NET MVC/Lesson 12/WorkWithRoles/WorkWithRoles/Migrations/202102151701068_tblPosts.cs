namespace WorkWithRoles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblPosts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Text = c.String(nullable: false),
                        DateRelease = c.String(nullable: false),
                        Author = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblPosts");
        }
    }
}
