using Microsoft.EntityFrameworkCore.Migrations;

namespace Finance_Management.Migrations
{
    public partial class CreateFinancedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_id = table.Column<decimal>(type: "numeric(18, 0)", nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    price = table.Column<decimal>(type: "decimal(10, 4)", nullable: true),
                    image = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    status = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__9833FF924032F31C", x => x.Product_id);
                });

            migrationBuilder.CreateTable(
                name: "User_Type",
                columns: table => new
                {
                    usertype_id = table.Column<decimal>(type: "numeric(18, 0)", nullable: false),
                    usertypename = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Type", x => x.usertype_id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderid = table.Column<decimal>(type: "numeric(20, 0)", nullable: false),
                    OrderAmount = table.Column<decimal>(type: "decimal(10, 3)", nullable: true),
                    orderdate = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Reg_id = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    product_id = table.Column<decimal>(type: "numeric(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Orders__080E37759ED46373", x => x.orderid);
                    table.ForeignKey(
                        name: "FK__Orders__product___245D67DE",
                        column: x => x.product_id,
                        principalTable: "Products",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logintype",
                columns: table => new
                {
                    Userid = table.Column<decimal>(type: "numeric(18, 0)", nullable: false),
                    password = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    usertype_id = table.Column<decimal>(type: "numeric(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Logintyp__1797D024F55017ED", x => x.Userid);
                    table.ForeignKey(
                        name: "FK__Logintype__usert__32AB8735",
                        column: x => x.usertype_id,
                        principalTable: "User_Type",
                        principalColumn: "usertype_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    paymentid = table.Column<decimal>(type: "numeric(18, 0)", nullable: false),
                    downpayment = table.Column<decimal>(type: "decimal(10, 3)", nullable: true),
                    remainingbalance = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    orderid = table.Column<decimal>(type: "numeric(20, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Payments__AF26EBEE7D3AF0AF", x => x.paymentid);
                    table.ForeignKey(
                        name: "FK__Payments__orderi__3C34F16F",
                        column: x => x.orderid,
                        principalTable: "Orders",
                        principalColumn: "orderid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    reg_id = table.Column<decimal>(type: "numeric(18, 0)", nullable: false),
                    fullName = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    number = table.Column<decimal>(type: "numeric(20, 0)", nullable: true),
                    address = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    cardtype = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    bank = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    accno = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    IFSC_code = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    userid = table.Column<decimal>(type: "numeric(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Registra__74038772994BCB02", x => x.reg_id);
                    table.ForeignKey(
                        name: "FK__Registrat__useri__367C1819",
                        column: x => x.userid,
                        principalTable: "Logintype",
                        principalColumn: "Userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emi_Table",
                columns: table => new
                {
                    emitype_id = table.Column<decimal>(type: "numeric(20, 0)", nullable: false),
                    emi_id = table.Column<decimal>(type: "numeric(10, 0)", nullable: true),
                    emiAmount = table.Column<decimal>(type: "decimal(10, 3)", nullable: true),
                    orderid = table.Column<decimal>(type: "numeric(20, 0)", nullable: true),
                    reg_id = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    paymentid = table.Column<decimal>(type: "numeric(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Emi_Tabl__66CDC93F8AA8606C", x => x.emitype_id);
                    table.ForeignKey(
                        name: "FK__Emi_Table__payme__489AC854",
                        column: x => x.paymentid,
                        principalTable: "Payments",
                        principalColumn: "paymentid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Emi_Table__reg_i__47A6A41B",
                        column: x => x.reg_id,
                        principalTable: "Registration",
                        principalColumn: "reg_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emi_Type",
                columns: table => new
                {
                    emiduration = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    emitype_id = table.Column<decimal>(type: "numeric(20, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__Emi_Type__emityp__4A8310C6",
                        column: x => x.emitype_id,
                        principalTable: "Emi_Table",
                        principalColumn: "emitype_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emi_Table_paymentid",
                table: "Emi_Table",
                column: "paymentid");

            migrationBuilder.CreateIndex(
                name: "IX_Emi_Table_reg_id",
                table: "Emi_Table",
                column: "reg_id");

            migrationBuilder.CreateIndex(
                name: "IX_Emi_Type_emitype_id",
                table: "Emi_Type",
                column: "emitype_id");

            migrationBuilder.CreateIndex(
                name: "IX_Logintype_usertype_id",
                table: "Logintype",
                column: "usertype_id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_product_id",
                table: "Orders",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_orderid",
                table: "Payments",
                column: "orderid");

            migrationBuilder.CreateIndex(
                name: "UQ__Registra__A472931CF277784B",
                table: "Registration",
                column: "accno",
                unique: true,
                filter: "[accno] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_userid",
                table: "Registration",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emi_Type");

            migrationBuilder.DropTable(
                name: "Emi_Table");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Registration");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Logintype");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "User_Type");
        }
    }
}
