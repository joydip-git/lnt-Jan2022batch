using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Person
    {
        protected string name;
        protected string department;

        public Person() { }

        public Person(string name, string departmentName)
        {
            this.name = name;
            this.department = departmentName;
        }

        public string Name
        {
            set => this.name = value;
            get => this.name;
        }

        public string Department
        {
            set => this.department = value;
            get => this.department;
        }

        //public string PrintInfo()
        //{
        //    return $"{name}, {department}";
        //}
    }
}
