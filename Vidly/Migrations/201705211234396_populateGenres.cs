namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (ID, Genre) Values(1, 'Comedy')");
            Sql("INSERT INTO Genres (ID, Genre) Values(2, 'Drama')");
            Sql("INSERT INTO Genres (ID, Genre) Values(3, 'Horror')");
            Sql("INSERT INTO Genres (ID, Genre) Values(4, 'Action')");
        }
        
        public override void Down()
        {
        }
    }
}
