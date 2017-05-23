namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMethodsAgain : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'281dead8-14f5-4141-85c9-535162504d5e', N'admin@vidly.com', 0, N'AJcsapUUFLyM689UGhmJCot9DIEHZDtR3tKBlbXEMa4+1sg8QlxpEaL7psD88W09FA==', N'2c233c15-04e4-47fc-8fd9-4ed2b75d4869', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'333058e2-adb8-4b5c-b1d7-9da3c05c4802', N'elliot.hurdiss@acumenci.com', 0, N'AH7fxQLKMxaRLh/8KKhthstdW4t5kcsDgvr/bvdHgskd15v0cbgsF/xtiIwh+CBbbQ==', N'788712b3-1072-4071-b417-d8a46f81442e', NULL, 0, 0, NULL, 1, 0, N'elliot.hurdiss@acumenci.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'47286b47-f641-45d0-a6f2-3a91aaa49d81', N'guest@vidly.com', 0, N'AHQDA9Bi6ouS7w6PjIh4l7pUbMnVPMVDIShCRd0TSJL5CYpLRPKVzSIunL2AIhSD9A==', N'f78f6b9d-1230-4f40-80ea-2ab601e2ee1f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')

                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'281dead8-14f5-4141-85c9-535162504d5e', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
