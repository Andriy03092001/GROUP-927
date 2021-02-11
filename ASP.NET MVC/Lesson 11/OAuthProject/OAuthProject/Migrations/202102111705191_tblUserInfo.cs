namespace OAuthProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblUserInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblUserAdditionalInfo",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUserAdditionalInfo", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.tblUserAdditionalInfo", new[] { "Id" });
            DropTable("dbo.tblUserAdditionalInfo");
        }
    }
}
