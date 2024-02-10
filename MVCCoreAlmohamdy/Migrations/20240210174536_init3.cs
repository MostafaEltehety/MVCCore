using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCCoreAlmohamdy.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37b3b03e-447a-45e4-879b-9a8e70c5b485", "0c8458af-c4aa-4bd7-af83-42ca05111c20", "User", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ce6f437-eae4-4438-8852-5a72e09c41f0", "ef502bd1-d3ea-41c7-97a5-0449ad6ba23f", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f71d92f-bc63-4123-aee1-e39f611b2aaf", "68d4603e-7d67-4893-baea-8c4ae0472851", "Manager", "manager" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37b3b03e-447a-45e4-879b-9a8e70c5b485");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ce6f437-eae4-4438-8852-5a72e09c41f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f71d92f-bc63-4123-aee1-e39f611b2aaf");

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
    }
}
