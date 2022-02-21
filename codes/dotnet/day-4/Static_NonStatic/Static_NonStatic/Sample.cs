using System;
using System.Collections.Generic;
using System.Text;

namespace Static_NonStatic
{
    class Sample
    {
        //non-static data
        public int firstData;
        //static data
        public static int secondData;

        //static method: can access only static data, method. Can't access any non-static data or method
        public static string Call()
        {
            return "Call method...";
        }

        //non-static (instance) method: can access non-static (instance) and static data, method, both
        public string SayHi()
        {
            return "Hi....";
        }
    }
}
