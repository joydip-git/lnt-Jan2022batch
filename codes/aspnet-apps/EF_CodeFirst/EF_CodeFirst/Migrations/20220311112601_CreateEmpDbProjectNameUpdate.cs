using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_CodeFirst.Migrations
{
    public partial class CreateEmpDbProjectNameUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "projectname",
                table: "employees",
                type: "varchar",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "projectname",
                table: "employees");
        }
    }
}
