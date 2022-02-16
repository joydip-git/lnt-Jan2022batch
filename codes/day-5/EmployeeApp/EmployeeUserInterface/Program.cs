using System;
using Entities;
//namespace is logical scope, inside which we write classes, interfaces and many other types

namespace EmployeeUserInterface
{
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee(1, "joy", 1000);
            Console.WriteLine(emp.Print());
        }
    }
}
