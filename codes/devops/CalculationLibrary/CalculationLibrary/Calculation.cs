using System;

namespace CalculationLibrary
{
    public class Calculation
    {
        public int Divide(int first, int second)
        {
            if (second == 0)
            {
                DivideByZeroException divEx = new DivideByZeroException("denominator should not be zero");
            }
            if (first < 0 || second < 0)
            {
                ArgumentException argsEx = new ArgumentException("arguments can not be less than zero");
                throw argsEx;
            }
            return first / second;
        }

        public int Add(int first, int second)
        {
            return first + second;
        }
    }
}
