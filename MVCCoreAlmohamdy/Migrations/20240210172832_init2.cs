using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCCoreAlmohamdy.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e09a118-6e35-42b2-8284-df8d6657c3c0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32f5e767-84bd-47fe-a9fe-382ad93b3432", "4d9c908d-d21a-4525-8f4b-44b9945e665b", "Manager", "manager" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b9c59da-993b-47f5-9c1d-39f02c09a897", "028e04fb-5b59-43a3-9170-e4bf635db603", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b9fd8309-cb4a-45fe-9972-13b850a346e2", "5196b853-035d-4340-b0d2-3e664c94675e", "Employee", "employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32f5e767-84bd-47fe-a9fe-382ad93b3432");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b9c59da-993b-47f5-9c1d-39f02c09a897");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9fd8309-cb4a-45fe-9972-13b850a346e2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0e09a118-6e35-42b2-8284-df8d6657c3c0", 0, "0eb90ee5-e3db-437a-983a-819c1bcd1a0d", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "Admin@123", null, false, "9a40c8f9-ab26-4dd8-9ed2-be37c8e67a68", false, "admin@admin.com" });
        }
    }
}
