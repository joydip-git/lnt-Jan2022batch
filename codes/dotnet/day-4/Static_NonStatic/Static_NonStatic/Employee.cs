using System;
using System.Collections.Generic;
using System.Text;

namespace Static_NonStatic
{
    class Employee
    {
        //static: it is used to declare data member or function which are common amongst all the objecst of this class
        //the data member memory will not be part of any object
        //the data member memory block will be allocated separately and every object can access that memory block
        //again static method or function is common among all the objects
        //so the static method or data is never accessed through object reference, rather through class name

        //field initialization
        //private static string companyName = "LnT";

        private static string companyName;
        private static string companyBranch;
        private string empName;
        private int empId;
        private decimal empSalary;

        //static constructor
        //it is used to assign values to ONLY static data members
        //this constructor is executed ONLY ONE TIME, (the very first time you create any object or you accessing any static member of the class very first time), no matter how many objects you create
        //static constructor is NEVER WRITTEN with any ACCESS SPECIFIER (do not use public, private or any other access specifier with static constructor)
        //static constructor is called automatically by runtime, YOU NEVER CALL IT
        //do not declare parameters for this constructor, since you never call it, so you do not have any chance to pass any values to it
        static Employee()
        {
            companyName = "LnT";
            companyBranch = "Mumbai";
        }
       
        //instance constructors can assign values to both static and non-static
        public Employee() { }

        //overloaded parameterized constructor
        public Employee(string name, int id, decimal salary)
        {
            //companyName = "LnT";
            empName = name;
            empId = id;
            empSalary = salary;
        }
        /*
        public Employee(string name, int id)
        {
            //companyName = "LnT";
            empName = name;
            empId = id;
        }
        public Employee(string name)
        {            
            empName = name;
        }
        */
        public string GetInfo()
        {
            return $"Name:{empName}, Company:{companyName}";
        }
    }
}
