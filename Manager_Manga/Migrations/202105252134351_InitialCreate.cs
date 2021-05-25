namespace Manager_Manga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        idCategory = c.String(nullable: false, maxLength: 128),
                        nameCategory = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.idCategory);
            
            CreateTable(
                "dbo.CategoryManga",
                c => new
                    {
                        idCategory = c.String(nullable: false, maxLength: 128),
                        idManga = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.idCategory, t.idManga })
                .ForeignKey("dbo.Category", t => t.idCategory, cascadeDelete: true)
                .ForeignKey("dbo.Manga", t => t.idManga, cascadeDelete: true)
                .Index(t => t.idCategory)
                .Index(t => t.idManga);
            
            CreateTable(
                "dbo.Manga",
                c => new
                    {
                        idManga = c.String(nullable: false, maxLength: 128),
                        name = c.String(nullable: false, maxLength: 80),
                        author = c.String(maxLength: 30),
                        source = c.String(),
                        numberChap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idManga);
            
            CreateTable(
                "dbo.Chap",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idManga = c.String(nullable: false, maxLength: 128),
                        nameChap = c.String(),
                        ContentManga = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Manga", t => t.idManga, cascadeDelete: true)
                .Index(t => t.idManga);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoryManga", "idManga", "dbo.Manga");
            DropForeignKey("dbo.Chap", "idManga", "dbo.Manga");
            DropForeignKey("dbo.CategoryManga", "idCategory", "dbo.Category");
            DropIndex("dbo.Chap", new[] { "idManga" });
            DropIndex("dbo.CategoryManga", new[] { "idManga" });
            DropIndex("dbo.CategoryManga", new[] { "idCategory" });
            DropTable("dbo.Chap");
            DropTable("dbo.Manga");
            DropTable("dbo.CategoryManga");
            DropTable("dbo.Category");
        }
    }
}
