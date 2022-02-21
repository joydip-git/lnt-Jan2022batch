using System;
using System.Collections.Generic;
using System.Text;

namespace Static_NonStatic
{
    //a static class 
    //static class must have ONLY static members (data or method)
    //no non-static members are allowed here
    //you CAN'T CREATE AN INSTANCE (OBJECT) OF STATIC CLASS
    //static class is also known as Utility class, since it's methods (or other members) are called frequently, such as Console, Convert class are all static classes
    static class Converter
    {
        static string data;
        static Converter()
        {
            data = "";
        }
        public static char ConvertUpperCaseToLowerCase(char ch)
        {
            if (char.IsUpper(ch))
                return char.ToLower(ch);
            else
                return ch;
        }
        public static char ConvertLowerCaseToUpperCase(char ch)
        {
            if (char.IsLower(ch))
                return char.ToUpper(ch);
            else
                return ch;
        }
    }
}
