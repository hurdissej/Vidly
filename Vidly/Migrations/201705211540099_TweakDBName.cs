namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TweakDBName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movie", new[] { "GenreID" });
            CreateIndex("dbo.Movie", "GenreId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Movie", new[] { "GenreId" });
            CreateIndex("dbo.Movie", "GenreID");
        }
    }
}
