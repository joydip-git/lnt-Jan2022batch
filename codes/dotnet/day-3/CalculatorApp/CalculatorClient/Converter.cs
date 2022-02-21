using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorClient
{
    class Converter
    {
        public static char ConvertUpperCaseDecisionToLower(char value)
        {
            bool isUpper = char.IsUpper(value);
            if (isUpper)
            {
                value = char.ToLower(value);
            }
            return value;
        }
        public static char ConvertLowerCaseDecisionToUppper(char value)
        {
            bool isLower = char.IsLower(value);
            if (isLower)
            {
                value = char.ToUpper(value);
            }
            return value;
        }
    }
}
