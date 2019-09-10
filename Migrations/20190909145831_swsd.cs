using Microsoft.EntityFrameworkCore.Migrations;

namespace UIPath.Migrations
{
    public partial class swsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsStudent",
                table: "UIPathStudents",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsStudent",
                table: "UIPathStudents",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}
