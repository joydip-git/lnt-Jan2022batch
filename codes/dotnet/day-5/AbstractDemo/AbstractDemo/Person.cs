using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
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
        public abstract bool IsOutstanding();
    }
}
