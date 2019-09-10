using Microsoft.EntityFrameworkCore.Migrations;

namespace UIPath.Migrations
{
    public partial class swd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsStudent",
                table: "UIPathStudents",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsStudent",
                table: "UIPathStudents",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
