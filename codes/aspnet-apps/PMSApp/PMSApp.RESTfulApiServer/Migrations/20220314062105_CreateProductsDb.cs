using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMSApp.RESTfulApiServer.Migrations
{
    public partial class CreateProductsDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100, 1"),
                    productname = table.Column<string>(type: "varchar(50)", nullable: false),
                    imagepath = table.Column<string>(type: "varchar(max)", nullable: true),
                    description = table.Column<string>(type: "varchar(max)", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValue: 0.0m),
                    starrating = table.Column<decimal>(type: "decimal(2,1)", nullable: true, defaultValue: 0.0m),
                    releaseddate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValue: new DateTime(2022, 3, 14, 11, 51, 5, 688, DateTimeKind.Local).AddTicks(5333))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products_productid", x => x.productid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
