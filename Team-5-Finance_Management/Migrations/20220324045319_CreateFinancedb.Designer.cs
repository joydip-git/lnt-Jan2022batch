﻿// <auto-generated />
using System;
using Finance_Management.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Finance_Management.Migrations
{
    [DbContext(typeof(FinancedbContext))]
    [Migration("20220324045319_CreateFinancedb")]
    partial class CreateFinancedb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Finance_Management.Repository.EmiTable", b =>
                {
                    b.Property<decimal>("EmitypeId")
                        .HasColumnName("emitype_id")
                        .HasColumnType("numeric(20, 0)");

                    b.Property<decimal?>("EmiAmount")
                        .HasColumnName("emiAmount")
                        .HasColumnType("decimal(10, 3)");

                    b.Property<decimal?>("EmiId")
                        .HasColumnName("emi_id")
                        .HasColumnType("numeric(10, 0)");

                    b.Property<decimal?>("Orderid")
                        .HasColumnName("orderid")
                        .HasColumnType("numeric(20, 0)");

                    b.Property<decimal?>("Paymentid")
                        .HasColumnName("paymentid")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("RegId")
                        .HasColumnName("reg_id")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("EmitypeId")
                        .HasName("PK__Emi_Tabl__66CDC93F8AA8606C");

                    b.HasIndex("Paymentid");

                    b.HasIndex("RegId");

                    b.ToTable("Emi_Table");
                });

            modelBuilder.Entity("Finance_Management.Repository.EmiType", b =>
                {
                    b.Property<string>("Emiduration")
                        .HasColumnName("emiduration")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<decimal?>("EmitypeId")
                        .HasColumnName("emitype_id")
                        .HasColumnType("numeric(20, 0)");

                    b.HasIndex("EmitypeId");

                    b.ToTable("Emi_Type");
                });

            modelBuilder.Entity("Finance_Management.Repository.Logintype", b =>
                {
                    b.Property<decimal>("Userid")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<decimal?>("UsertypeId")
                        .HasColumnName("usertype_id")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("Userid")
                        .HasName("PK__Logintyp__1797D024F55017ED");

                    b.HasIndex("UsertypeId");

                    b.ToTable("Logintype");
                });

            modelBuilder.Entity("Finance_Management.Repository.Orders", b =>
                {
                    b.Property<decimal>("Orderid")
                        .HasColumnName("orderid")
                        .HasColumnType("numeric(20, 0)");

                    b.Property<decimal?>("OrderAmount")
                        .HasColumnType("decimal(10, 3)");

                    b.Property<string>("Orderdate")
                        .HasColumnName("orderdate")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<decimal?>("ProductId")
                        .HasColumnName("product_id")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("RegId")
                        .HasColumnName("Reg_id")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("Orderid")
                        .HasName("PK__Orders__080E37759ED46373");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Finance_Management.Repository.Payments", b =>
                {
                    b.Property<decimal>("Paymentid")
                        .HasColumnName("paymentid")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("Downpayment")
                        .HasColumnName("downpayment")
                        .HasColumnType("decimal(10, 3)");

                    b.Property<decimal?>("Orderid")
                        .HasColumnName("orderid")
                        .HasColumnType("numeric(20, 0)");

                    b.Property<decimal?>("Remainingbalance")
                        .HasColumnName("remainingbalance")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("Paymentid")
                        .HasName("PK__Payments__AF26EBEE7D3AF0AF");

                    b.HasIndex("Orderid");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Finance_Management.Repository.Products", b =>
                {
                    b.Property<decimal>("ProductId")
                        .HasColumnName("Product_id")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Image")
                        .HasColumnName("image")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<decimal?>("Price")
                        .HasColumnName("price")
                        .HasColumnType("decimal(10, 4)");

                    b.Property<string>("Status")
                        .HasColumnName("status")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("ProductId")
                        .HasName("PK__Products__9833FF924032F31C");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Finance_Management.Repository.Registration", b =>
                {
                    b.Property<decimal>("RegId")
                        .HasColumnName("reg_id")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Accno")
                        .HasColumnName("accno")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Address")
                        .HasColumnName("address")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Bank")
                        .HasColumnName("bank")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Cardtype")
                        .HasColumnName("cardtype")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("FullName")
                        .HasColumnName("fullName")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("IfscCode")
                        .HasColumnName("IFSC_code")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<decimal?>("Number")
                        .HasColumnName("number")
                        .HasColumnType("numeric(20, 0)");

                    b.Property<decimal?>("Userid")
                        .HasColumnName("userid")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("RegId")
                        .HasName("PK__Registra__74038772994BCB02");

                    b.HasIndex("Accno")
                        .IsUnique()
                        .HasName("UQ__Registra__A472931CF277784B")
                        .HasFilter("[accno] IS NOT NULL");

                    b.HasIndex("Userid");

                    b.ToTable("Registration");
                });

            modelBuilder.Entity("Finance_Management.Repository.UserType", b =>
                {
                    b.Property<decimal>("UsertypeId")
                        .HasColumnName("usertype_id")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Usertypename")
                        .HasColumnName("usertypename")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("UsertypeId");

                    b.ToTable("User_Type");
                });

            modelBuilder.Entity("Finance_Management.Repository.EmiTable", b =>
                {
                    b.HasOne("Finance_Management.Repository.Payments", "Payment")
                        .WithMany("EmiTable")
                        .HasForeignKey("Paymentid")
                        .HasConstraintName("FK__Emi_Table__payme__489AC854");

                    b.HasOne("Finance_Management.Repository.Registration", "Reg")
                        .WithMany("EmiTable")
                        .HasForeignKey("RegId")
                        .HasConstraintName("FK__Emi_Table__reg_i__47A6A41B");
                });

            modelBuilder.Entity("Finance_Management.Repository.EmiType", b =>
                {
                    b.HasOne("Finance_Management.Repository.EmiTable", "Emitype")
                        .WithMany()
                        .HasForeignKey("EmitypeId")
                        .HasConstraintName("FK__Emi_Type__emityp__4A8310C6");
                });

            modelBuilder.Entity("Finance_Management.Repository.Logintype", b =>
                {
                    b.HasOne("Finance_Management.Repository.UserType", "Usertype")
                        .WithMany("Logintype")
                        .HasForeignKey("UsertypeId")
                        .HasConstraintName("FK__Logintype__usert__32AB8735");
                });

            modelBuilder.Entity("Finance_Management.Repository.Orders", b =>
                {
                    b.HasOne("Finance_Management.Repository.Products", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__Orders__product___245D67DE");
                });

            modelBuilder.Entity("Finance_Management.Repository.Payments", b =>
                {
                    b.HasOne("Finance_Management.Repository.Orders", "Order")
                        .WithMany("Payments")
                        .HasForeignKey("Orderid")
                        .HasConstraintName("FK__Payments__orderi__3C34F16F");
                });

            modelBuilder.Entity("Finance_Management.Repository.Registration", b =>
                {
                    b.HasOne("Finance_Management.Repository.Logintype", "User")
                        .WithMany("Registration")
                        .HasForeignKey("Userid")
                        .HasConstraintName("FK__Registrat__useri__367C1819");
                });
#pragma warning restore 612, 618
        }
    }
}
