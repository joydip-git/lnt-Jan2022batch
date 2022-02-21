using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class TextFileDataAccess : DataAccess
    {
        string txtfilePath;

        public override string Path 
        { 
            get => txtfilePath; 
            set => txtfilePath = value; 
        }

        public override string GetData()
        {
            return "text file data";
        }
    }
}
