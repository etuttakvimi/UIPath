using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UIPath.Migrations
{
    public partial class groups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "UIPathStudents",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Consultants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Statu = table.Column<int>(nullable: false),
                    LabName = table.Column<string>(nullable: true),
                    GroupName = table.Column<string>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    ConsultantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UIPathStudents_GroupId",
                table: "UIPathStudents",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ConsultantId",
                table: "Groups",
                column: "ConsultantId");

            migrationBuilder.AddForeignKey(
                name: "FK_UIPathStudents_Groups_GroupId",
                table: "UIPathStudents",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UIPathStudents_Groups_GroupId",
                table: "UIPathStudents");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Consultants");

            migrationBuilder.DropIndex(
                name: "IX_UIPathStudents_GroupId",
                table: "UIPathStudents");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "UIPathStudents");
        }
    }
}
