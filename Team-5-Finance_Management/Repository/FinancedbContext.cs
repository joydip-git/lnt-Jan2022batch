using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Management.Repository
{
    public partial class FinancedbContext : DbContext
    {
        public FinancedbContext()
        {
        }

        public FinancedbContext(DbContextOptions<FinancedbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmiTable> EmiTable { get; set; }
        public virtual DbSet<EmiType> EmiType { get; set; }
        public virtual DbSet<Logintype> Logintype { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MSI; Initial Catalog=Financedb; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmiTable>(entity =>
            {
                entity.HasKey(e => e.EmitypeId)
                    .HasName("PK__Emi_Tabl__66CDC93F8AA8606C");

                entity.ToTable("Emi_Table");

                entity.Property(e => e.EmitypeId)
                    .HasColumnName("emitype_id")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.EmiAmount)
                    .HasColumnName("emiAmount")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.EmiId)
                    .HasColumnName("emi_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.Paymentid)
                    .HasColumnName("paymentid")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegId)
                    .HasColumnName("reg_id")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.EmiTable)
                    .HasForeignKey(d => d.Paymentid)
                    .HasConstraintName("FK__Emi_Table__payme__489AC854");

                entity.HasOne(d => d.Reg)
                    .WithMany(p => p.EmiTable)
                    .HasForeignKey(d => d.RegId)
                    .HasConstraintName("FK__Emi_Table__reg_i__47A6A41B");
            });

            modelBuilder.Entity<EmiType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Emi_Type");

                entity.Property(e => e.Emiduration)
                    .HasColumnName("emiduration")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmitypeId)
                    .HasColumnName("emitype_id")
                    .HasColumnType("numeric(20, 0)");

                entity.HasOne(d => d.Emitype)
                    .WithMany()
                    .HasForeignKey(d => d.EmitypeId)
                    .HasConstraintName("FK__Emi_Type__emityp__4A8310C6");
            });

            modelBuilder.Entity<Logintype>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__Logintyp__1797D024F55017ED");

                entity.Property(e => e.Userid).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsertypeId)
                    .HasColumnName("usertype_id")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Usertype)
                    .WithMany(p => p.Logintype)
                    .HasForeignKey(d => d.UsertypeId)
                    .HasConstraintName("FK__Logintype__usert__32AB8735");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.Orderid)
                    .HasName("PK__Orders__080E37759ED46373");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.OrderAmount).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Orderdate)
                    .HasColumnName("orderdate")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegId)
                    .HasColumnName("Reg_id")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Orders__product___245D67DE");
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.HasKey(e => e.Paymentid)
                    .HasName("PK__Payments__AF26EBEE7D3AF0AF");

                entity.Property(e => e.Paymentid)
                    .HasColumnName("paymentid")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Downpayment)
                    .HasColumnName("downpayment")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.Remainingbalance)
                    .HasColumnName("remainingbalance")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Orderid)
                    .HasConstraintName("FK__Payments__orderi__3C34F16F");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__9833FF924032F31C");

                entity.Property(e => e.ProductId)
                    .HasColumnName("Product_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.RegId)
                    .HasName("PK__Registra__74038772994BCB02");

                entity.HasIndex(e => e.Accno)
                    .HasName("UQ__Registra__A472931CF277784B")
                    .IsUnique();

                entity.Property(e => e.RegId)
                    .HasColumnName("reg_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Accno)
                    .HasColumnName("accno")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Bank)
                    .HasColumnName("bank")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cardtype)
                    .HasColumnName("cardtype")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasColumnName("fullName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IfscCode)
                    .HasColumnName("IFSC_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__Registrat__useri__367C1819");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("User_Type");

                entity.Property(e => e.UsertypeId)
                    .HasColumnName("usertype_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Usertypename)
                    .HasColumnName("usertypename")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
