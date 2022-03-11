using System;
using EF_CodeFirst.Repository;
using System.Linq;

namespace EF_CodeFirst
{
    class Program
    {
        static void Main()
        {
            using (var db = new EmployeeDbContext())
            {
                //db.Departments.AddRange(new Department { DepartmentName="HR"}, new Department { DepartmentName = "Training" });
                //db.SaveChanges();
               
                //db.Departments.ToList<Department>().ForEach(d => Console.WriteLine(d.DepartmentName));

                //db.Employees.AddRange(new Employee { EmployeeName = "joydip", Salary = 1000, ProjectName = "CITA", DepartmentId = 1 }, new Employee { EmployeeName = "sunil", Salary = 2000, ProjectName = "ABC", DepartmentId = 2 });
                //db.SaveChanges();

                //db.Employees.ToList<Employee>().ForEach(e => Console.WriteLine(e.EmployeeName));
            }
        }
    }
}
