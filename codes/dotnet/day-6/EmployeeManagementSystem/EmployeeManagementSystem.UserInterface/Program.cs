using System;
using System.Collections.Generic;
using EmployeeManagementSystem.BusinessLayer;
using EmployeeManagementSystem.Entities;

namespace EmployeeManagementSystem.UserInterface
{
    class Program
    {
        static void Main()
        {
            EmployeeBo employeeBo = null;
            try
            {
                employeeBo = new EmployeeBo();
                List<Employee> employees = employeeBo.GetEmployeeRecords(1);
                if (employees.Count > 0)
                {
                    foreach (Employee employee in employees)
                    {
                        Console.WriteLine(employee.EmployeeName);
                    }
                }
                else
                    Console.WriteLine("no records found...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
