namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenresIn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        Genre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Movie", "GenreID", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movie", "GenreID");
            AddForeignKey("dbo.Movie", "GenreID", "dbo.Genres", "ID", cascadeDelete: true);
            DropColumn("dbo.Movie", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "Genre", c => c.String());
            DropForeignKey("dbo.Movie", "GenreID", "dbo.Genres");
            DropIndex("dbo.Movie", new[] { "GenreID" });
            DropColumn("dbo.Movie", "GenreID");
            DropTable("dbo.Genres");
        }
    }
}
