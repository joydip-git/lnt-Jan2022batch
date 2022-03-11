using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;//Key
//using System.ComponentModel.DataAnnotations.Schema;//Table, Column
using System.Text;

namespace EF_CodeFirst.Repository
{
    /*
    //Data Annotation: mapping the entity model class with table and its properties with columns using data annotation attribute, like, Table, Column, Key etc.
    [Table("employees")]
    public class Employee
    {
        [Key]
        [Column("employeid", Order = 0, TypeName = "int")]
        public int EmployeeId { get; set; }

        [Column("employeename", Order = 1, TypeName = "varchar(50)")]
        public string EmployeeName { get; set; }

        [Column("employeesalary", Order = 2, TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
    }
    */
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }
        public string ProjectName { get; set; }

        //foreign key column
        public int DepartmentId { get; set; }

        //navigation property. this does not map to any column
        public Department DepartmentInfo { get; set; }
    }
}
