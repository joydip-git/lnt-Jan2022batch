using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CodeFirst.Repository
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { set; get; }
        public DbSet<Department> Departments { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=joydip-pc;database=empdb;user id=sa;password=sqlserver2017");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API: a technique (thorugh APIs) to map an entity class to a table and its proeprties to the columns, decide which one will be primary key etc.

            EntityTypeBuilder<Department> deptEntityBuilder = modelBuilder.Entity<Department>();

            deptEntityBuilder.ToTable("departments");
            deptEntityBuilder.HasKey(dept => dept.DepartmentId)
                .HasName("PK_departments_departmentid");

            deptEntityBuilder
                .Property(dept => dept.DepartmentId)
                .HasColumnName("departmentid")
                .HasColumnType("int")
                .IsRequired()
                .UseIdentityColumn(1, 1);

            deptEntityBuilder
                .Property(dept => dept.DepartmentName)
                .HasColumnName("departmentname")
                .HasColumnType("varchar(20)")
                .IsRequired();

            EntityTypeBuilder<Employee> employeeEntityBuilder = modelBuilder.Entity<Employee>();

            employeeEntityBuilder.ToTable("employees");

            employeeEntityBuilder
                .HasKey(empModel => empModel.EmployeeId)
                .HasName("pk_employees_employeeid");

            employeeEntityBuilder
                .Property(empModel => empModel.EmployeeId)
                .HasColumnName("employeeid")
                .HasColumnType("int")
                .UseIdentityColumn(100, 1)
                .IsRequired();

            employeeEntityBuilder
                .Property(empModel => empModel.EmployeeName)
                .HasColumnName("employeename")
                .HasColumnType("varchar(50)")
                .IsRequired();

            employeeEntityBuilder
               .Property(empModel => empModel.Salary)
               .HasColumnName("employeesalary")
               .HasColumnType("decimal(18,2)")
               .HasDefaultValue(0);

            employeeEntityBuilder
             .Property(empModel => empModel.ProjectName)
             .HasColumnName("projectname")
             .HasColumnType("varchar(20)");

            employeeEntityBuilder
                .Property(empModel => empModel.DepartmentId)
                .HasColumnName("departmentid")
                .HasColumnType("int");

            employeeEntityBuilder
                .HasOne<Department>(empModel => empModel.DepartmentInfo)
                .WithMany(dept => dept.Employees)
                .HasForeignKey(empModel => empModel.DepartmentId);
        }
    }
}
