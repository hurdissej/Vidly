using System.Data.Entity.Core.Metadata.Edm;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershupTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(ID, DisplayName, SignUpFee, DurationInMOnths, DiscountRate) Values (1, \"Pay as you go\", 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes(ID, DisplayName, SignUpFee, DurationInMOnths, DiscountRate) Values (2, \"Monthly\" , 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes(ID, DisplayName, SignUpFee, DurationInMOnths, DiscountRate) Values (3, \"Quarterly\" , 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes(ID, DisplayName, SignUpFee, DurationInMOnths, DiscountRate) Values (4, \"Yearly\" , 300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
