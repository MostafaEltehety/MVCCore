using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCCoreAlmohamdy.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0e09a118-6e35-42b2-8284-df8d6657c3c0", 0, "0eb90ee5-e3db-437a-983a-819c1bcd1a0d", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "Admin@123", null, false, "9a40c8f9-ab26-4dd8-9ed2-be37c8e67a68", false, "admin@admin.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e09a118-6e35-42b2-8284-df8d6657c3c0");
        }
    }
}
