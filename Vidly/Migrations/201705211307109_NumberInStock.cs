namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NumberInStock : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "NumberInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "NumberInStock");
        }
    }
}
