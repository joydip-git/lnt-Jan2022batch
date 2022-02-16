using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApp
{
    class Employee
    {
        readonly int employeeId;
        string employeeName;
        decimal basicPayment;
        decimal daPayment;
        decimal hraPayment;
        decimal totalSalary;

        public Employee() { }
        public Employee(int id)
        {
            employeeId = id;
        }
        public Employee(int id, string name, decimal basicPay, decimal daPay, decimal hraPay)
        {
            employeeId = id;
            employeeName = name;
            basicPayment = basicPay;
            daPayment = daPay;
            hraPayment = hraPay;
        }

        public int EmployeeId => employeeId;
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public decimal BasicPayment { get => basicPayment; set => basicPayment = value; }
        public decimal DaPayment { get => daPayment; set => daPayment = value; }
        public decimal HraPayment { get => hraPayment; set => hraPayment = value; }
        public decimal TotalSalary => totalSalary;

        public void CalculateSalary()
        {
            this.totalSalary = this.basicPayment + this.daPayment + this.hraPayment;
        }
    }
}
