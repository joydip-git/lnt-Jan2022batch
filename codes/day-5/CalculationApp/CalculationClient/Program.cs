using System;
using CalculationLibrary;

namespace CalculationClient
{
    class Program
    {
        static void Main()
        {
            Calculation calc = new Calculation();
            int res = calc.Add(12, 13);
            Console.WriteLine(res);
        }
    }
}
