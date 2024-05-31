using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'791e56df-d6b3-438e-9a43-de4069b49606', N'admin', N'ADMIN', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMrLgH9GHV1aowg0VA8MUGbBpwt4Dhiqm5cuFR6isUmoBISr02kmjukxK1XPqxK8xg==', N'QB6Q4J5ZTN2GCLZEHDALNH5L27O3JHNS', N'12cf962a-a2f8-475b-989c-ef288865891f', NULL, 0, 0, NULL, 1, 0, N'HoaiNhan', N'LamHoai', NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id = '791e56df-d6b3-438e-9a43-de4069b49606'");
        }
    }
}
