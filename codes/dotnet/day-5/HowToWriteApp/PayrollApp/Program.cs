using System;

namespace PayrollApp
{
    class Program
    {
        static Employee CreateEmployee()
        {
            /*
            Console.Write("name: ");
            string name = Console.ReadLine();

            Console.Write("id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("basic: ");
            decimal basic = decimal.Parse(Console.ReadLine());

            Console.Write("da: ");
            decimal da = decimal.Parse(Console.ReadLine());

            Console.Write("hra: ");
            decimal hra = decimal.Parse(Console.ReadLine());

            Employee employeeObjectRef = new Employee(id, name, basic, da, hra);
            return employeeObjectRef;
            */
            Console.Write("id: ");
            int id = int.Parse(Console.ReadLine());
            Employee employeeObjectRef = new Employee(id);

            Console.Write("name: ");
            //string name = Console.ReadLine();
            employeeObjectRef.EmployeeName =Console.ReadLine();
            
            Console.Write("basic: ");
            //decimal basic = decimal.Parse(Console.ReadLine());
            //employeeObjectRef.BasicPayment = basic;
            employeeObjectRef.BasicPayment = decimal.Parse(Console.ReadLine());

            Console.Write("da: ");
            employeeObjectRef.DaPayment = decimal.Parse(Console.ReadLine());

            Console.Write("hra: ");
            employeeObjectRef.HraPayment = decimal.Parse(Console.ReadLine());
            
            return employeeObjectRef;
        }
        static void PrintSalary(Employee employee)
        {
            employee.CalculateSalary();
            Console.WriteLine($"Total Salary of {employee.EmployeeName} is {employee.TotalSalary}");
        }
        static void Main()
        {
            Employee empRef = CreateEmployee();
            PrintSalary(empRef);
        }
    }
}
