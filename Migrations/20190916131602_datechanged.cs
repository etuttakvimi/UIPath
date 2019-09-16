using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UIPath.Migrations
{
    public partial class datechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StartDate",
                table: "Groups",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EndDate",
                table: "Groups",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Groups",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Groups",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
