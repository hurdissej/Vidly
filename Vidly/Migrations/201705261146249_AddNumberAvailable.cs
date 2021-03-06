namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "NumberAvailable", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "NumberAvailable");
        }
    }
}
