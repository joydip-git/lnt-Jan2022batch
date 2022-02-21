using System;

namespace PassByValueReferenceOut
{
    class UserInterface
    {
        static int GetNumberFromUser()
        {
            Console.Write("enter a number: ");
            string num = Console.ReadLine();
            int number = int.Parse(num);
            return number;
        }
        
        static void Main()
        {
            //accept values from user
            int value = GetNumberFromUser();
            //call other functions, pass these accepted values and get the return value
            bool status = EvenOddFinderLogic.IsEvenOrOdd(value);
            //print the return value(s) in the console
            if(status)
                Console.WriteLine($"{value} is even");
            else
                Console.WriteLine($"{value} is odd");
        }
    }
}
