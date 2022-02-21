using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class DatabaseDataAccess: DataAccess
    {
        string dbPath;
        public override string Path 
        { 
            get => dbPath;
            set => dbPath = value; 
        }

        public override string GetData()
        {
            return "sql server employees table data";
        }
    }
}
