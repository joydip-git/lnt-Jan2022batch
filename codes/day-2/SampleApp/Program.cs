using System;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; //4 bytes
            int b = 20;//010101100
            int result = a + b;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
