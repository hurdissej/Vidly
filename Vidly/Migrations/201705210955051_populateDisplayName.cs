namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateDisplayName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes Set Displayname = 'Pay as you go' Where ID  = 1");
            Sql("UPDATE MembershipTypes Set Displayname = 'Monthly' Where ID  = 2");
            Sql("UPDATE MembershipTypes Set Displayname = 'Quarterly' Where ID  = 3");
            Sql("UPDATE MembershipTypes Set Displayname = 'Yearly' Where ID  = 4");
        }
        
        public override void Down()
        {
        }
    }
}
