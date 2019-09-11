using Microsoft.EntityFrameworkCore.Migrations;

namespace UIPath.Migrations
{
    public partial class lass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TCKN",
                table: "UIPathStudents",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "TCKN",
                table: "Students",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TCKN",
                table: "UIPathStudents",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TCKN",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
