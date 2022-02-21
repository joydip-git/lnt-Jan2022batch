using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionOverloadingApp
{
    class Addition
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return (firstNumber + secondNumber);
        }
        public int Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            return (firstNumber + secondNumber + thirdNumber);
        }
        public long Add(int firstNumber, int secondNumber, long thirdNumber)
        {
            return (firstNumber + secondNumber + thirdNumber);
        }
        public short Add(int firstNumber, long secondNumber, int thirdNumber)
        {
            return (short)(firstNumber + secondNumber + thirdNumber);
        }
        public double Add(double firstNumber, double secondNumber, double thirdNumber)
        {
            return (firstNumber + secondNumber + thirdNumber);
        }
    }
}
