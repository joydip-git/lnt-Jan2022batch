using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamSystemApp.Migrations
{
    public partial class CreateOnlineExamDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "difficultylevel",
                columns: table => new
                {
                    level_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    level_name = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__difficul__03461643AA4342A4", x => x.level_id);
                });

            migrationBuilder.CreateTable(
                name: "examcategory",
                columns: table => new
                {
                    category_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_name = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__examcate__D54EE9B41E000F92", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "usertype",
                columns: table => new
                {
                    type_id = table.Column<int>(nullable: false),
                    type_name = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__usertype__2C0005985EE93F8E", x => x.type_id);
                });

            migrationBuilder.CreateTable(
                name: "questionbank",
                columns: table => new
                {
                    q_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    q_text = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    level_id = table.Column<int>(nullable: true),
                    category_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__question__3D59B3104EDDE90F", x => x.q_id);
                    table.ForeignKey(
                        name: "FK_Cetg_QBank_Id",
                        column: x => x.category_id,
                        principalTable: "examcategory",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Level_QBank_Id",
                        column: x => x.level_id,
                        principalTable: "difficultylevel",
                        principalColumn: "level_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    email_id = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    password = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    type_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__login__3FEF876664F0A551", x => x.email_id);
                    table.ForeignKey(
                        name: "FK_UType_Login_ID",
                        column: x => x.type_id,
                        principalTable: "usertype",
                        principalColumn: "type_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "answerbank",
                columns: table => new
                {
                    ans_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ans_text = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    q_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__answerba__24F9FB17E6ADFA10", x => x.ans_id);
                    table.ForeignKey(
                        name: "FK_OBank_ABank_Id",
                        column: x => x.q_id,
                        principalTable: "questionbank",
                        principalColumn: "q_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "registration",
                columns: table => new
                {
                    reg_id = table.Column<int>(nullable: false),
                    user_name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    email_id = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dob = table.Column<DateTime>(type: "date", nullable: false),
                    city = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    state = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    qualification = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    completion_yr = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__registra__7403877280229C06", x => x.reg_id);
                    table.ForeignKey(
                        name: "FK_Login_Reg_ID",
                        column: x => x.email_id,
                        principalTable: "login",
                        principalColumn: "email_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "userexamrecord",
                columns: table => new
                {
                    exam_entry_id = table.Column<int>(nullable: false),
                    email_id = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    score = table.Column<int>(nullable: false),
                    level_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__userexam__509F803F4A9B88B7", x => x.exam_entry_id);
                    table.ForeignKey(
                        name: "FK_Login_UExamRec_ID",
                        column: x => x.email_id,
                        principalTable: "login",
                        principalColumn: "email_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DLevel_ID",
                        column: x => x.level_id,
                        principalTable: "difficultylevel",
                        principalColumn: "level_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "correctanswer",
                columns: table => new
                {
                    correct_ans_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    q_id = table.Column<int>(nullable: true),
                    ans_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__correcta__99C9B7148B3E6D37", x => x.correct_ans_id);
                    table.ForeignKey(
                        name: "FK_ABank_CrtAns_Id",
                        column: x => x.ans_id,
                        principalTable: "answerbank",
                        principalColumn: "ans_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QBank_CrtAns_Id",
                        column: x => x.q_id,
                        principalTable: "questionbank",
                        principalColumn: "q_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_answerbank_q_id",
                table: "answerbank",
                column: "q_id");

            migrationBuilder.CreateIndex(
                name: "IX_correctanswer_ans_id",
                table: "correctanswer",
                column: "ans_id");

            migrationBuilder.CreateIndex(
                name: "IX_correctanswer_q_id",
                table: "correctanswer",
                column: "q_id");

            migrationBuilder.CreateIndex(
                name: "IX_login_type_id",
                table: "login",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_questionbank_category_id",
                table: "questionbank",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_questionbank_level_id",
                table: "questionbank",
                column: "level_id");

            migrationBuilder.CreateIndex(
                name: "IX_registration_email_id",
                table: "registration",
                column: "email_id");

            migrationBuilder.CreateIndex(
                name: "IX_userexamrecord_email_id",
                table: "userexamrecord",
                column: "email_id");

            migrationBuilder.CreateIndex(
                name: "IX_userexamrecord_level_id",
                table: "userexamrecord",
                column: "level_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "correctanswer");

            migrationBuilder.DropTable(
                name: "registration");

            migrationBuilder.DropTable(
                name: "userexamrecord");

            migrationBuilder.DropTable(
                name: "answerbank");

            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "questionbank");

            migrationBuilder.DropTable(
                name: "usertype");

            migrationBuilder.DropTable(
                name: "examcategory");

            migrationBuilder.DropTable(
                name: "difficultylevel");
        }
    }
}
