using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionOverriiding
{
    class Student : Person
    {
        string[] subjects;
        double[] marks;

        public Student() { }

        public Student(string name, string[] subjects, string departmentName, double[] allMarks)
            : base(name, departmentName)
        {
            //this.name = name;
            //this.department = departmentName;
            this.subjects = subjects;
            this.marks = allMarks;
        }

        public string[] Subjects
        {
            set => this.subjects = value;
            get => this.subjects;
        }

        public double[] Marks
        {
            set => this.marks = value;
            get => this.marks;
        }
        public override string PrintInfo()
        {
            string info = base.PrintInfo();
            return $"{info},{subjects}, {marks}";
        }
    }
}
