using System;

namespace ControlFlowStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //IfLoop(); 
            //SwitchCase();
            WhileLoop();
        }
        static void WhileLoop()
        {
            int a = 5;
            while (a > 0)
            {
                Console.WriteLine($"value of a is {a} in while loop");
                //a = a - 1;
                a--;
            }

            do
            {
                Console.WriteLine($"value of a is {a} in do..while loop");
                //a = a - 1;
                a--;
            } while (a > 6);
        }
        static void SwitchCase()
        {
            Console.WriteLine("1. Save in Database");
            Console.WriteLine("2. Save in File");

            Console.Write("\n Enter a choice[1/2]: ");
            string strChoice = Console.ReadLine(); //1 --> "1" --> 1
            int choice = int.Parse(strChoice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n Save data in database");
                    break;

                case 2:
                    Console.WriteLine("\n Save data in a file");
                    break;

                default:
                    Console.WriteLine("\n Enter a proper choice.");
                    break;
            }

            //if (choice == 1)
            //{

            //}
            //else if (choice == 2)
            //{

            //}
            //else
            //{

            //}
        }
        static void IfLoop()
        {
            int a = 1;
            int b = 2;
            int c = 3;

            if (a > b)
            {
                if (a > c)
                    Console.WriteLine($"{a} is greatest of all");
                else
                    Console.WriteLine($"{c} is the greatest of all");
            }
            else
            {
                Console.WriteLine($"{b} is greatest of all");
            }
        }
    }
}
