using Microsoft.EntityFrameworkCore.Migrations;

namespace UIPath.Migrations
{
    public partial class tc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Brans",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Seans",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TCKN",
                table: "Students",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brans",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Seans",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TCKN",
                table: "Students");
        }
    }
}
