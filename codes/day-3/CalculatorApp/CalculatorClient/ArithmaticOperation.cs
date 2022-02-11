using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorClient
{
    //The class containing methods for adding, subtracting, multiplying and dividing two numbers
    class ArithmaticOperation
    {        
        public static int Add(int firstValue, int secondValue)
        {
            int result = firstValue + secondValue;
            return result;
        }
        public static int Subtract(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
                return (firstValue - secondValue);
            else
                return secondValue - firstValue;
        }
        public static int Multiply(int firstValue, int secondValue)
        {
            return (firstValue * secondValue);
        }
        public static int Divide(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
                return (firstValue / secondValue);
            else
                return secondValue / firstValue;
        }
    }
}
