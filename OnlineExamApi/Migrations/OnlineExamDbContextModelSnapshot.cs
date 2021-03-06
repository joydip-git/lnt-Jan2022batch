// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineExamSystemApp.Models;

namespace OnlineExamSystemApp.Migrations
{
    [DbContext(typeof(OnlineExamDbContext))]
    partial class OnlineExamDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineExamSystemApp.Models.Answerbank", b =>
                {
                    b.Property<int>("AnsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ans_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnsText")
                        .HasColumnName("ans_text")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("QId")
                        .HasColumnName("q_id")
                        .HasColumnType("int");

                    b.HasKey("AnsId")
                        .HasName("PK__answerba__24F9FB17E6ADFA10");

                    b.HasIndex("QId");

                    b.ToTable("answerbank");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Correctanswer", b =>
                {
                    b.Property<int>("CorrectAnsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("correct_ans_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnsId")
                        .HasColumnName("ans_id")
                        .HasColumnType("int");

                    b.Property<int?>("QId")
                        .HasColumnName("q_id")
                        .HasColumnType("int");

                    b.HasKey("CorrectAnsId")
                        .HasName("PK__correcta__99C9B7148B3E6D37");

                    b.HasIndex("AnsId");

                    b.HasIndex("QId");

                    b.ToTable("correctanswer");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Difficultylevel", b =>
                {
                    b.Property<int>("LevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("level_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LevelName")
                        .HasColumnName("level_name")
                        .HasColumnType("int");

                    b.HasKey("LevelId")
                        .HasName("PK__difficul__03461643AA4342A4");

                    b.ToTable("difficultylevel");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Examcategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("category_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnName("category_name")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("CategoryId")
                        .HasName("PK__examcate__D54EE9B41E000F92");

                    b.ToTable("examcategory");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Login", b =>
                {
                    b.Property<string>("EmailId")
                        .HasColumnName("email_id")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("TypeId")
                        .HasColumnName("type_id")
                        .HasColumnType("int");

                    b.HasKey("EmailId")
                        .HasName("PK__login__3FEF876664F0A551");

                    b.HasIndex("TypeId");

                    b.ToTable("login");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Questionbank", b =>
                {
                    b.Property<int>("QId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("q_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnName("category_id")
                        .HasColumnType("int");

                    b.Property<int?>("LevelId")
                        .HasColumnName("level_id")
                        .HasColumnType("int");

                    b.Property<string>("QText")
                        .IsRequired()
                        .HasColumnName("q_text")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("QId")
                        .HasName("PK__question__3D59B3104EDDE90F");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LevelId");

                    b.ToTable("questionbank");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Registration", b =>
                {
                    b.Property<int>("RegId")
                        .HasColumnName("reg_id")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("city")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("CompletionYr")
                        .HasColumnName("completion_yr")
                        .HasColumnType("date");

                    b.Property<DateTime>("Dob")
                        .HasColumnName("dob")
                        .HasColumnType("date");

                    b.Property<string>("EmailId")
                        .HasColumnName("email_id")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnName("qualification")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnName("state")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnName("user_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("RegId")
                        .HasName("PK__registra__7403877280229C06");

                    b.HasIndex("EmailId");

                    b.ToTable("registration");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Userexamrecord", b =>
                {
                    b.Property<int>("ExamEntryId")
                        .HasColumnName("exam_entry_id")
                        .HasColumnType("int");

                    b.Property<string>("EmailId")
                        .HasColumnName("email_id")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("LevelId")
                        .HasColumnName("level_id")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnName("score")
                        .HasColumnType("int");

                    b.HasKey("ExamEntryId")
                        .HasName("PK__userexam__509F803F4A9B88B7");

                    b.HasIndex("EmailId");

                    b.HasIndex("LevelId");

                    b.ToTable("userexamrecord");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Usertype", b =>
                {
                    b.Property<int>("TypeId")
                        .HasColumnName("type_id")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnName("type_name")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("TypeId")
                        .HasName("PK__usertype__2C0005985EE93F8E");

                    b.ToTable("usertype");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Answerbank", b =>
                {
                    b.HasOne("OnlineExamSystemApp.Models.Questionbank", "Q")
                        .WithMany("Answerbank")
                        .HasForeignKey("QId")
                        .HasConstraintName("FK_OBank_ABank_Id");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Correctanswer", b =>
                {
                    b.HasOne("OnlineExamSystemApp.Models.Answerbank", "Ans")
                        .WithMany("Correctanswer")
                        .HasForeignKey("AnsId")
                        .HasConstraintName("FK_ABank_CrtAns_Id");

                    b.HasOne("OnlineExamSystemApp.Models.Questionbank", "Q")
                        .WithMany("Correctanswer")
                        .HasForeignKey("QId")
                        .HasConstraintName("FK_QBank_CrtAns_Id");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Login", b =>
                {
                    b.HasOne("OnlineExamSystemApp.Models.Usertype", "Type")
                        .WithMany("Login")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK_UType_Login_ID");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Questionbank", b =>
                {
                    b.HasOne("OnlineExamSystemApp.Models.Examcategory", "Category")
                        .WithMany("Questionbank")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Cetg_QBank_Id");

                    b.HasOne("OnlineExamSystemApp.Models.Difficultylevel", "Level")
                        .WithMany("Questionbank")
                        .HasForeignKey("LevelId")
                        .HasConstraintName("FK_Level_QBank_Id");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Registration", b =>
                {
                    b.HasOne("OnlineExamSystemApp.Models.Login", "Email")
                        .WithMany("Registration")
                        .HasForeignKey("EmailId")
                        .HasConstraintName("FK_Login_Reg_ID");
                });

            modelBuilder.Entity("OnlineExamSystemApp.Models.Userexamrecord", b =>
                {
                    b.HasOne("OnlineExamSystemApp.Models.Login", "Email")
                        .WithMany("Userexamrecord")
                        .HasForeignKey("EmailId")
                        .HasConstraintName("FK_Login_UExamRec_ID");

                    b.HasOne("OnlineExamSystemApp.Models.Difficultylevel", "Level")
                        .WithMany("Userexamrecord")
                        .HasForeignKey("LevelId")
                        .HasConstraintName("FK_DLevel_ID");
                });
#pragma warning restore 612, 618
        }
    }
}
