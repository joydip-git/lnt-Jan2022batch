using System;

namespace CalculatorClient
{
    class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("--------MENU---------");
            Console.WriteLine("1. Add \n2. Subtract \n3. Multiply \n4. Divide");
        }
        static int AskUserForChoice()
        {
            Console.Write("\nEnter Choice[1/2/3/4]: ");
            string strChoice = Console.ReadLine();
            int choice = int.Parse(strChoice);
            return choice;
        }
        static void Calculate(int userChoice, int firstNumber, int secondNumber)
        {
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("\nCallIng Add Method. ");
                    int addResult = ArithmaticOperation.Add(firstNumber, secondNumber);
                    Console.WriteLine($"Addition of {firstNumber} and {secondNumber} is:{addResult} ");
                    break;

                case 2:
                    Console.WriteLine("\nCallIng Subtract Method. ");
                    int subtractResult = ArithmaticOperation.Subtract(firstNumber, secondNumber);
                    Console.WriteLine($"Subtraction of {firstNumber} and {secondNumber} is:{subtractResult} ");
                    break;

                case 3:
                    Console.WriteLine("\nCallIng Multiply Method. ");
                    int multiplytResult = ArithmaticOperation.Multiply(firstNumber, secondNumber);
                    Console.WriteLine($"Multiplication of {firstNumber} and {secondNumber} is:{multiplytResult} ");
                    break;

                case 4:
                    Console.WriteLine("\nCallIng Divide Method. ");
                    int divideResult = ArithmaticOperation.Divide(firstNumber, secondNumber);
                    Console.WriteLine($"Division of {firstNumber} and {secondNumber} is:{divideResult} ");
                    break;

                default:
                    Console.WriteLine("\n Enter proper choice");
                    break;
            }
        }
        static char AskUserWhetherToContinueOrNot()
        {
            Console.Write("\nLike to continue?[Y/y/N/n]: ");
            string strDecision = Console.ReadLine();
            char decision = char.Parse(strDecision);
            return decision;
        }
        static int EnterNumber()
        {
            Console.Write("\nEnter Number: ");
            string strValue = Console.ReadLine();
            int number = int.Parse(strValue);
            return number;
        }

        static void Main()
        {            
            char decision = 'n';
            do
            {
                PrintMenu();
                int userChoice = AskUserForChoice();

                int firstNumber = EnterNumber();
                int secondNumber = EnterNumber();

                Calculate(userChoice, firstNumber, secondNumber);

                decision = AskUserWhetherToContinueOrNot();
                decision = Converter.ConvertUpperCaseDecisionToLower(decision);                

            } while (decision != 'n');
        }
    }
}
