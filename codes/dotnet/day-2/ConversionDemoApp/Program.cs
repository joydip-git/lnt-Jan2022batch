using System;

namespace ConversionDemoApp
{
    class Program
    {
        static void Main()
        {
            //implicit conversion (Value type --> value type)
            //int x = 10;
            //long l = x;
            //Console.WriteLine(l);

            //explicit conversion (value type --> value type)
            //long l = 1234567898967543;
            //int x = checked((int)l);
            //Console.WriteLine(x);


            //implicit conversion (value type --> reference type)
            //int a = 12;
            //string numStr = a.ToString();
            //Console.WriteLine(numStr);

            //explicit conversion  (reference type -->  value type)
            string str = "12";
            //int num = int.Parse(str);
            int num = Convert.ToInt32(str);
            Console.WriteLine(num);
        }
    }
}
