using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DummyProject.DataAccessLayer.Models
{
    public partial class productsdbContext : DbContext
    {
        public productsdbContext()
        {
        }

        public productsdbContext(DbContextOptions<productsdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=joydip-pc;database=productsdb;user id=sa;password=sqlserver2017");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.Productid)
                    .HasName("PK_products_productid");

                entity.ToTable("products");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Imagepath)
                    .HasColumnName("imagepath")
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Productname)
                    .IsRequired()
                    .HasColumnName("productname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Releaseddate)
                    .HasColumnName("releaseddate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2022-03-14T11:51:05.688')");

                entity.Property(e => e.Starrating)
                    .HasColumnName("starrating")
                    .HasColumnType("decimal(2, 1)")
                    .HasDefaultValueSql("((0.0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
