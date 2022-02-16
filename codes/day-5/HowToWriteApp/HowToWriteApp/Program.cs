using System;

namespace HowToWriteApp
{
    class Program
    {
        static string GetValueFromUser()
        {
            Console.Write("enter a number: ");
            string numberValue = Console.ReadLine();
            return numberValue;
        }
        static bool ConvertStringToInteger(string numberValue, out int value)
        {
            bool possibleToConvert = int.TryParse(numberValue, out value);
            return possibleToConvert;
        }
        static string IsEvnOrOdd(int number)
        {
            if (number % 2 == 0)
                return $"{number} is even";
            else
                return $"{number} is odd";
        }
        static void Main()
        {
            //1. ask user to enter
            string numberValue = GetValueFromUser();

            //2. get the string converted to int
            int number;
            bool status = ConvertStringToInteger(numberValue, out number);

            //3. check whether even or odd and print
            if (status)
            {
                string result = IsEvnOrOdd(number);
                Console.WriteLine(result);
            }
            else
                Console.WriteLine($"Not possible to decide even or odd, since value in some other format was entered apart from integer format");

        }
    }
}
