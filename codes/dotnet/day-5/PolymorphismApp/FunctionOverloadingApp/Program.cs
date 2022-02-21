using System;

namespace FunctionOverloadingApp
{
    class Program
    {
        static void Main()
        {
            Addition addition = new Addition();

            //caller line
            Console.WriteLine(addition.Add(10, 20));

            //caller line
            Console.WriteLine(addition.Add(12.34, 13.45, 56.7));
        }
    }
}
