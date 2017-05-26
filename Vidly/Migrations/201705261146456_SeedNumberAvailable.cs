namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedNumberAvailable : DbMigration
    {
        public override void Up()
        {
            Sql("Update dbo.movies set [numberavailable] = [numberinstock]");
        }
        
        public override void Down()
        {
        }
    }
}
