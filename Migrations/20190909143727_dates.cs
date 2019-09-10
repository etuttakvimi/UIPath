using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UIPath.Migrations
{
    public partial class dates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseDate",
                table: "UIPathStudents",
                newName: "CourseStartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CourseEndDate",
                table: "UIPathStudents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseEndDate",
                table: "UIPathStudents");

            migrationBuilder.RenameColumn(
                name: "CourseStartDate",
                table: "UIPathStudents",
                newName: "CourseDate");
        }
    }
}
