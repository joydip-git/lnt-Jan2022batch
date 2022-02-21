using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    abstract class DataAccess
    {
        protected string data;
        public DataAccess() { }

        public string Data { get => data; }

        public abstract string GetData();
        public abstract string Path { set; get; }
    }
}
