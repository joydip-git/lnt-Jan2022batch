using System;

namespace EvenOddFinderApp
{
    class Program
    {
        static void Main()
        {
            //Program.IsEven();
            //WriteLine: prints something in the console and then adds a newline character (\n)
            //Write: prints something in the console and does not add a newline character (\n)

            Console.Write("enter a number: ");

            //ReadLine: accepts value/input (complete stream) from user in the console
            string strNumber = Console.ReadLine(); //12 --> "12"--> 12
            //convert the string format value into actual number format

            //Parse method ONLY converts string format to target, is possible
            int number = int.Parse(strNumber);

            //Any method (for ex. ToInt32()) of Convert class can convert ANY TYPE of data to target, if possible
            //int number = Convert.ToInt32(strNumber);
           
            //int number = 5;
            bool status = IsEvenOrOdd(number);
            if (status)
                Console.WriteLine($"{number} is even");
            else
                Console.WriteLine($"{number} is odd");
        }

        static bool IsEvenOrOdd(int value)
        {
            //if (value % 2 == 0)
            //    Console.WriteLine($"{value} is even");
            //else
            //    Console.WriteLine($"{value} is odd");

            //business logic
            if (value % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
