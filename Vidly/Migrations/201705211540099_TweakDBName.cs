namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TweakDBName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", new[] { "GenreID" });
            CreateIndex("dbo.Movies", "GenreId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Movies", new[] { "GenreId" });
            CreateIndex("dbo.Movies", "GenreID");
        }
    }
}
