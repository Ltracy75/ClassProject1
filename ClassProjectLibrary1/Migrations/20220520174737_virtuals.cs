using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassProjectLibrary1.Migrations
{
    public partial class virtuals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectsId",
                table: "Works",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResourcesId",
                table: "Works",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Works_ProjectsId",
                table: "Works",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_ResourcesId",
                table: "Works",
                column: "ResourcesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Projects_ProjectsId",
                table: "Works",
                column: "ProjectsId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Resources_ResourcesId",
                table: "Works",
                column: "ResourcesId",
                principalTable: "Resources",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Works_Projects_ProjectsId",
                table: "Works");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Resources_ResourcesId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_ProjectsId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_ResourcesId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "ProjectsId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "ResourcesId",
                table: "Works");
        }
    }
}
