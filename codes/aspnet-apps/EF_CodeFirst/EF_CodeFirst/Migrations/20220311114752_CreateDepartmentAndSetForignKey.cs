using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_CodeFirst.Migrations
{
    public partial class CreateDepartmentAndSetForignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentid",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    departmentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmentname = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments_departmentid", x => x.departmentid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_departmentid",
                table: "employees",
                column: "departmentid");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_departmentid",
                table: "employees",
                column: "departmentid",
                principalTable: "departments",
                principalColumn: "departmentid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_departmentid",
                table: "employees");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropIndex(
                name: "IX_employees_departmentid",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "departmentid",
                table: "employees");
        }
    }
}
