namespace UniversityManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewstable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ImageURL = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        ReleaseDate = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblNews");
        }
    }
}
