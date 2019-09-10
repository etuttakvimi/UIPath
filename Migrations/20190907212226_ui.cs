using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UIPath.Migrations
{
    public partial class ui : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brans",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Seans",
                table: "Students");

            migrationBuilder.CreateTable(
                name: "UIPathStudents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Mail = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Seans = table.Column<int>(nullable: false),
                    Brans = table.Column<int>(nullable: false),
                    TCKN = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UIPathStudents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UIPathStudents");

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
        }
    }
}
