using System;
using System.Collections.Generic;
using System.Text;

namespace SortingElements
{
    class Employee
    {
        string name;
        readonly int id;
        decimal salary;

        public Employee()
        {

        }

        public Employee(int id)
        {
            this.id = id;
        }

        public Employee(string name, int id, decimal salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; }
        public decimal Salary { get => salary; set => salary = value; }
    }
}
