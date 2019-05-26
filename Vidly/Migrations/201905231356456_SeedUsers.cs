namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'664bb589-388a-4a46-9962-c1a703481df2', N'admin@vidly.com', 0, N'AHkN3FXfUa8aWvlbM/44UFHGbGEihc94fGFr0Lx0ADfEMdkplSiZsqkw8LCif49ulg==', N'd1b62816-de41-4cba-875b-ce5ff71a6e24', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'75bc9fb1-3d44-478d-94c9-e6c2a421332d', N'guest@vidly.com', 0, N'AOaJS/IRHrTXLoFGbSLfuEjfkhfw9kwj14r+8O2kQwtBV1vrpA1FDY9PSr9dEbaLrQ==', N'0c0af276-cd37-4164-aa5d-f1e09edf0948', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e51523dc-f67a-478b-8139-342c0ce22044', N'CanManageMovies')
           
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'664bb589-388a-4a46-9962-c1a703481df2', N'e51523dc-f67a-478b-8139-342c0ce22044')


        ");
        }
        
        public override void Down()
        {
        }
    }
}
