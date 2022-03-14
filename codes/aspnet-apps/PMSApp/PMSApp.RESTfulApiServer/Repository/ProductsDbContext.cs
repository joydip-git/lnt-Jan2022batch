using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMSApp.RESTfulApiServer.Repository
{
    public class ProductsDbContext : DbContext
    {
        public ICollection<Product> Products { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=joydip-pc;database=productsdb;user id=sa;password=sqlserver2017");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(productModel =>
            {
                productModel.ToTable("products");
                productModel
                .HasKey(pm => pm.ProductId)
                .HasName("PK_products_productid");

                productModel
                .Property(pm => pm.ProductId)
                .HasColumnName("productid")
                .HasColumnType("int")
                .UseIdentityColumn(100, 1)
                .IsRequired();

                productModel
                .Property(pm => pm.ProductName)
                .HasColumnName("productname")
                .HasColumnType("varchar(50)")
                .IsRequired();

                productModel
                .Property(pm => pm.Description)
                .HasColumnName("description")
                .HasColumnType("varchar(max)");

                productModel
                .Property(pm => pm.ImagePath)
                .HasColumnName("imagepath")
                .HasColumnType("varchar(max)");

                productModel
                .Property(pm => pm.Price)
                .HasColumnName("price")
                .HasColumnType("decimal(18,2)")
                .HasDefaultValue(0.0M);

                productModel
                .Property(pm => pm.StarRating)
                .HasColumnName("starrating")
                .HasColumnType("decimal(2,1)")
                .HasDefaultValue(0.0M);

                productModel
                .Property(pm => pm.ReleasedDate)
                .HasColumnName("releaseddate")
                .HasColumnType("datetime")
                .HasDefaultValue(DateTime.Now);
            });
        }
    }
}
