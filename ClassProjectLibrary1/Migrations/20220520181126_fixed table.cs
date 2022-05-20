using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassProjectLibrary1.Migrations
{
    public partial class fixedtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Projects_ProjectsId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Projects_ProjectsId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Resources");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectsId",
                table: "Works",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProjectsId",
                table: "Resources",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Projects_ProjectsId",
                table: "Resources",
                column: "ProjectsId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Projects_ProjectsId",
                table: "Works",
                column: "ProjectsId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Projects_ProjectsId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Projects_ProjectsId",
                table: "Works");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectsId",
                table: "Works",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Works",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProjectsId",
                table: "Resources",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Resources",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Projects_ProjectsId",
                table: "Resources",
                column: "ProjectsId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Projects_ProjectsId",
                table: "Works",
                column: "ProjectsId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
