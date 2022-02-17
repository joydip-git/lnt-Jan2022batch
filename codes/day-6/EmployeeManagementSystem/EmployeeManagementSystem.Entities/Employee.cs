using System;

namespace EmployeeManagementSystem.Entities
{
    public class Employee
    {
        int employeeId;
        string employeeName;
        decimal employeeSalary;
        int departmentId;

        public Employee()
        {

        }
        public Employee(int employeeId, string employeeName, decimal employeeSalary, int departmentId)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.employeeSalary = employeeSalary;
            this.departmentId = departmentId;
        }

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public decimal EmployeeSalary { get => employeeSalary; set => employeeSalary = value; }
        public int DepartmentId { get => departmentId; set => departmentId = value; }
    }
}
