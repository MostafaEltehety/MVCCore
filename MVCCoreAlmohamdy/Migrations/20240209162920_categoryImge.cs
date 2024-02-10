using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCCoreAlmohamdy.Migrations
{
    public partial class categoryImge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "CatImage",
                table: "Categories",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatImage",
                table: "Categories");
        }
    }
}
