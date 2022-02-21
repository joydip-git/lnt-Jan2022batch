using System;
using System.Collections.Generic;
using System.Text;

namespace CompleteApp
{
    abstract class Person
    {
        string name;

        public Person()
        {
        }

        public Person(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

        public virtual string PrintInfo()
        {
            return $"Name: {name}";
        }
        public abstract bool IsOutstanding();
    }
}
