namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertiesToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movie", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "ReleaseDate");
            DropColumn("dbo.Movie", "DateAdded");
        }
    }
}
