using System;

namespace Entities
{
    public class Employee
    {
        string name;
        int id;
        decimal salary;

        public Employee()
        {

        }

        public Employee(int id, string name, decimal salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public string Print()
        {
            return $"{name}, {id}, {salary}";
        }
    }
}
