using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionOverriiding
{
    class Staff: Person
    {
        string level;

        public Staff() { }

        public Staff(string name, string departmentName, string level)
            : base(name, departmentName)
        {
            this.level = level;
            //base.memberName
        }

        public string Level
        {
            set => this.level = value;
            get => this.level;
        }
        public override string PrintInfo()
        {
            string info = base.PrintInfo();
            return $"{info}, {level}";
        }
    }
}
