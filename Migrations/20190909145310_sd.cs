using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UIPath.Migrations
{
    public partial class sd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CourseStartDate",
                table: "UIPathStudents",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseEndDate",
                table: "UIPathStudents",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsStudent",
                table: "UIPathStudents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsStudent",
                table: "UIPathStudents");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CourseStartDate",
                table: "UIPathStudents",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CourseEndDate",
                table: "UIPathStudents",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
