namespace GameFixFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConsoleNameColAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Developers",
                c => new
                    {
                        DeveloperId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DeveloperId);
            
            CreateTable(
                "dbo.GameLibraries",
                c => new
                    {
                        GameLibraryId = c.Int(nullable: false, identity: true),
                        GenreId = c.Int(nullable: false),
                        DeveloperId = c.Int(nullable: false),
                        Title = c.String(),
                        Year = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GameArtUrl = c.String(),
                        Console = c.String(),
                    })
                .PrimaryKey(t => t.GameLibraryId)
                .ForeignKey("dbo.Developers", t => t.DeveloperId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.DeveloperId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GameLibraries", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.GameLibraries", "DeveloperId", "dbo.Developers");
            DropIndex("dbo.GameLibraries", new[] { "DeveloperId" });
            DropIndex("dbo.GameLibraries", new[] { "GenreId" });
            DropTable("dbo.Genres");
            DropTable("dbo.GameLibraries");
            DropTable("dbo.Developers");
        }
    }
}
