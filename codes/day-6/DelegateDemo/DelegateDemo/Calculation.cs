using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo
{
    class Calculation
    {
        public void Add(int first, int second)
        {
            Console.WriteLine(first + second);
        }
        public static void Subtract(int first, int second)
        {
            Console.WriteLine(first - second);
        }
    }
}
