using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Genaralinsuranceapp.Migrations
{
    public partial class CreateGeneralInsurance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "claimreasons",
                columns: table => new
                {
                    claim_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    claimreason = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__claimrea__F9CC0896B5DA3726", x => x.claim_id);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Registration",
                columns: table => new
                {
                    customer_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, nullable: true),
                    password = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime", nullable: true),
                    contact_no = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    policy_number = table.Column<int>(nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__CD65CB8517EE82D5", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "insuranceduration",
                columns: table => new
                {
                    duration_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    duration_value = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__insuranc__7EB98060C42ACC99", x => x.duration_id);
                });

            migrationBuilder.CreateTable(
                name: "insuranceplantype",
                columns: table => new
                {
                    plan_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    planname = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__insuranc__BE9F8F1D13E9C4E1", x => x.plan_id);
                });

            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__login__AB6E6165D55A04F5", x => x.email);
                });

            migrationBuilder.CreateTable(
                name: "vehicletypes",
                columns: table => new
                {
                    vehicletype_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vehicletype = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__vehiclet__20A37C0CEA8C5DFF", x => x.vehicletype_id);
                });

            migrationBuilder.CreateTable(
                name: "policydetails",
                columns: table => new
                {
                    policy_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    duration_id = table.Column<int>(nullable: true),
                    plan_id = table.Column<int>(nullable: true),
                    customer_id = table.Column<long>(nullable: true),
                    vehicletype_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__policyde__96916873F4BE3DCA", x => x.policy_number);
                    table.ForeignKey(
                        name: "FK__policydet__vehic__59FA5E80",
                        column: x => x.customer_id,
                        principalTable: "Customer_Registration",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__policydet__durat__5AEE82B9",
                        column: x => x.duration_id,
                        principalTable: "insuranceduration",
                        principalColumn: "duration_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__policydet__plan___5BE2A6F2",
                        column: x => x.plan_id,
                        principalTable: "insuranceplantype",
                        principalColumn: "plan_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__policydet__vehic__5CD6CB2B",
                        column: x => x.vehicletype_id,
                        principalTable: "vehicletypes",
                        principalColumn: "vehicletype_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Claimdata",
                columns: table => new
                {
                    policy_number = table.Column<int>(nullable: false),
                    claim_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Claimdat__96916873961704A3", x => x.policy_number);
                    table.ForeignKey(
                        name: "FK__Claimdata__claim__22751F6C",
                        column: x => x.claim_id,
                        principalTable: "claimreasons",
                        principalColumn: "claim_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Claimdata__polic__2180FB33",
                        column: x => x.policy_number,
                        principalTable: "policydetails",
                        principalColumn: "policy_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "claimhistory",
                columns: table => new
                {
                    claim_no = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    policy_number = table.Column<int>(nullable: true),
                    is_Approved = table.Column<bool>(nullable: true),
                    amount = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    claim_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__claimhis__F9CC1145BDF7E59B", x => x.claim_no);
                    table.ForeignKey(
                        name: "FK__claimhist__claim__60A75C0F",
                        column: x => x.claim_id,
                        principalTable: "claimreasons",
                        principalColumn: "claim_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__claimhist__polic__5FB337D6",
                        column: x => x.policy_number,
                        principalTable: "policydetails",
                        principalColumn: "policy_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vehiclesdetails",
                columns: table => new
                {
                    registration_number = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    manufacturer = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    customer_id = table.Column<long>(nullable: true),
                    Vehicle_Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    policy_number = table.Column<int>(nullable: true),
                    model = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    driving_license_number = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    engine_number = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    chasis_number = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    purchase_date = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__vehicles__125DB2A2B93D18C0", x => x.registration_number);
                    table.ForeignKey(
                        name: "FK__vehiclesd__custo__6383C8BA",
                        column: x => x.customer_id,
                        principalTable: "Customer_Registration",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__vehiclesd__polic__6477ECF3",
                        column: x => x.policy_number,
                        principalTable: "policydetails",
                        principalColumn: "policy_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Claimdata_claim_id",
                table: "Claimdata",
                column: "claim_id");

            migrationBuilder.CreateIndex(
                name: "IX_claimhistory_claim_id",
                table: "claimhistory",
                column: "claim_id");

            migrationBuilder.CreateIndex(
                name: "IX_claimhistory_policy_number",
                table: "claimhistory",
                column: "policy_number");

            migrationBuilder.CreateIndex(
                name: "IX_policydetails_customer_id",
                table: "policydetails",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_policydetails_duration_id",
                table: "policydetails",
                column: "duration_id");

            migrationBuilder.CreateIndex(
                name: "IX_policydetails_plan_id",
                table: "policydetails",
                column: "plan_id");

            migrationBuilder.CreateIndex(
                name: "IX_policydetails_vehicletype_id",
                table: "policydetails",
                column: "vehicletype_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehiclesdetails_customer_id",
                table: "vehiclesdetails",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehiclesdetails_policy_number",
                table: "vehiclesdetails",
                column: "policy_number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claimdata");

            migrationBuilder.DropTable(
                name: "claimhistory");

            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "vehiclesdetails");

            migrationBuilder.DropTable(
                name: "claimreasons");

            migrationBuilder.DropTable(
                name: "policydetails");

            migrationBuilder.DropTable(
                name: "Customer_Registration");

            migrationBuilder.DropTable(
                name: "insuranceduration");

            migrationBuilder.DropTable(
                name: "insuranceplantype");

            migrationBuilder.DropTable(
                name: "vehicletypes");
        }
    }
}
