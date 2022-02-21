using System;
using System.Collections.Generic;

namespace SortingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 3, 2, 5, 6, 4, 0, 7, 9, 8 };
            numbers.Sort();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Employee anilEmp = new Employee("anil", 2, 3000);
            Employee sunilEmp = new Employee("sunil", 1, 2000);
            Employee joyEmp = new Employee("joy", 3, 1000);

            //object initialzer
            //Employee anilEmp = new Employee { Name = "sunil", Salary = 3000 };


            //collection initializer
            List<Employee> employees = new List<Employee> { anilEmp, sunilEmp, joyEmp };
            //employees.Add(anilEmp);
            //employees.Add(anilEmp);
            //employees.Add(anilEmp);

            Console.WriteLine("1. sort by name \n2. sort by id \n3. sort by salary");
            Console.Write("enter choice[1/2/3]: ");
            int choice = int.Parse(Console.ReadLine());

            EmployeeComparison employeeComparison = new EmployeeComparison(choice);
            //pass object of such a class which implements IComparer<T> interface
            //means the class has 'public int Compare(T x, T y)' method in it implemented
            employees.Sort(employeeComparison);

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Salary}");
            }
        }
    }
}
