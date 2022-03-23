using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Genaralinsuranceapp.Repository
{
    public partial class generalinsuranceContext : DbContext
    {
        public generalinsuranceContext()
        {
        }

        public generalinsuranceContext(DbContextOptions<generalinsuranceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Claimdata> Claimdata { get; set; }
        public virtual DbSet<Claimhistory> Claimhistory { get; set; }
        public virtual DbSet<Claimreasons> Claimreasons { get; set; }
        public virtual DbSet<CustomerRegistration> CustomerRegistration { get; set; }
        public virtual DbSet<Insuranceduration> Insuranceduration { get; set; }
        public virtual DbSet<Insuranceplantype> Insuranceplantype { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Policydetails> Policydetails { get; set; }
        public virtual DbSet<Vehiclesdetails> Vehiclesdetails { get; set; }
        public virtual DbSet<Vehicletypes> Vehicletypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=generalinsurance;user id=sa;password=sqlserver2017");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Claimdata>(entity =>
            {
                entity.HasKey(e => e.PolicyNumber)
                    .HasName("PK__Claimdat__96916873961704A3");

                entity.HasIndex(e => e.ClaimId);

                entity.Property(e => e.PolicyNumber)
                    .HasColumnName("policy_number")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.Claimdata)
                    .HasForeignKey(d => d.ClaimId)
                    .HasConstraintName("FK__Claimdata__claim__22751F6C");

                entity.HasOne(d => d.PolicyNumberNavigation)
                    .WithOne(p => p.Claimdata)
                    .HasForeignKey<Claimdata>(d => d.PolicyNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Claimdata__polic__2180FB33");
            });

            modelBuilder.Entity<Claimhistory>(entity =>
            {
                entity.HasKey(e => e.ClaimNo)
                    .HasName("PK__claimhis__F9CC1145BDF7E59B");

                entity.ToTable("claimhistory");

                entity.HasIndex(e => e.ClaimId);

                entity.HasIndex(e => e.PolicyNumber);

                entity.Property(e => e.ClaimNo).HasColumnName("claim_no");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.IsApproved).HasColumnName("is_Approved");

                entity.Property(e => e.PolicyNumber).HasColumnName("policy_number");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.Claimhistory)
                    .HasForeignKey(d => d.ClaimId)
                    .HasConstraintName("FK__claimhist__claim__60A75C0F");

                entity.HasOne(d => d.PolicyNumberNavigation)
                    .WithMany(p => p.Claimhistory)
                    .HasForeignKey(d => d.PolicyNumber)
                    .HasConstraintName("FK__claimhist__polic__5FB337D6");
            });

            modelBuilder.Entity<Claimreasons>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("PK__claimrea__F9CC0896B5DA3726");

                entity.ToTable("claimreasons");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.Claimreason)
                    .HasColumnName("claimreason")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerRegistration>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__CD65CB8517EE82D5");

                entity.ToTable("Customer_Registration");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contact_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNumber).HasColumnName("policy_number");
            });

            modelBuilder.Entity<Insuranceduration>(entity =>
            {
                entity.HasKey(e => e.DurationId)
                    .HasName("PK__insuranc__7EB98060C42ACC99");

                entity.ToTable("insuranceduration");

                entity.Property(e => e.DurationId).HasColumnName("duration_id");

                entity.Property(e => e.DurationValue)
                    .HasColumnName("duration_value")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Insuranceplantype>(entity =>
            {
                entity.HasKey(e => e.PlanId)
                    .HasName("PK__insuranc__BE9F8F1D13E9C4E1");

                entity.ToTable("insuranceplantype");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.Planname)
                    .HasColumnName("planname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK__login__AB6E6165D55A04F5");

                entity.ToTable("login");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Policydetails>(entity =>
            {
                entity.HasKey(e => e.PolicyNumber)
                    .HasName("PK__policyde__96916873F4BE3DCA");

                entity.ToTable("policydetails");

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.DurationId);

                entity.HasIndex(e => e.PlanId);

                entity.HasIndex(e => e.VehicletypeId);

                entity.Property(e => e.PolicyNumber).HasColumnName("policy_number");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DurationId).HasColumnName("duration_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.VehicletypeId).HasColumnName("vehicletype_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Policydetails)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__policydet__vehic__59FA5E80");

                entity.HasOne(d => d.Duration)
                    .WithMany(p => p.Policydetails)
                    .HasForeignKey(d => d.DurationId)
                    .HasConstraintName("FK__policydet__durat__5AEE82B9");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Policydetails)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK__policydet__plan___5BE2A6F2");

                entity.HasOne(d => d.Vehicletype)
                    .WithMany(p => p.Policydetails)
                    .HasForeignKey(d => d.VehicletypeId)
                    .HasConstraintName("FK__policydet__vehic__5CD6CB2B");
            });

            modelBuilder.Entity<Vehiclesdetails>(entity =>
            {
                entity.HasKey(e => e.RegistrationNumber)
                    .HasName("PK__vehicles__125DB2A2B93D18C0");

                entity.ToTable("vehiclesdetails");

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.PolicyNumber);

                entity.Property(e => e.RegistrationNumber)
                    .HasColumnName("registration_number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChasisNumber)
                    .HasColumnName("chasis_number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DrivingLicenseNumber)
                    .HasColumnName("driving_license_number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EngineNumber)
                    .HasColumnName("engine_number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNumber).HasColumnName("policy_number");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnName("purchase_date")
                    .HasColumnType("date");

                entity.Property(e => e.VehicleTypeId).HasColumnName("Vehicle_Type_Id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Vehiclesdetails)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__vehiclesd__custo__6383C8BA");

                entity.HasOne(d => d.PolicyNumberNavigation)
                    .WithMany(p => p.Vehiclesdetails)
                    .HasForeignKey(d => d.PolicyNumber)
                    .HasConstraintName("FK__vehiclesd__polic__6477ECF3");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Vehiclesdetails)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .HasConstraintName("Fk_vehicledetails_vehicletypes_vehicletypeid");
            });

            modelBuilder.Entity<Vehicletypes>(entity =>
            {
                entity.HasKey(e => e.VehicletypeId)
                    .HasName("PK__vehiclet__20A37C0CEA8C5DFF");

                entity.ToTable("vehicletypes");

                entity.Property(e => e.VehicletypeId).HasColumnName("vehicletype_id");

                entity.Property(e => e.Vehicletype)
                    .HasColumnName("vehicletype")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
