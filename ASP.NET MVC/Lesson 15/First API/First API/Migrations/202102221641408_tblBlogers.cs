namespace First_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblBlogers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblBlogers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CountSubscribers = c.Int(nullable: false),
                        Platform = c.String(nullable: false),
                        AgeAudience = c.Int(nullable: false),
                        CategoryContent = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Image = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblBlogers");
        }
    }
}
