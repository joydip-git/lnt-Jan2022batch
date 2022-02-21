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
        /*
        static int AskUserForChoice()
        {
            Console.Write("\nEnter Choice[1/2/3/4]: ");
            string strChoice = Console.ReadLine();
            int choice = int.Parse(strChoice);
            return choice;
        }
        */
        static void AskUserForChoice(out int choice)
        {
            Console.Write("\nEnter Choice[1/2/3/4]: ");
            string strChoice = Console.ReadLine();
            int.TryParse(strChoice, out choice);
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
        /*
         *older version
        static char AskUserWhetherToContinueOrNot()
        {
            Console.Write("\nLike to continue?[Y/y/N/n]: ");
            string strDecision = Console.ReadLine();
            char decision = char.Parse(strDecision);
            return decision;
        }
        */

        static void AskUserWhetherToContinueOrNot(ref char decision)
        { 
            Console.Write("\nLike to continue?[Y/y/N/n]: ");
            string strDecision = Console.ReadLine();
            decision = char.Parse(strDecision);            
        }
        /*
        static int EnterNumber()
        {
            Console.Write("\nEnter Number: ");
            string strValue = Console.ReadLine();
            int number = int.Parse(strValue);
            return number;
        }
        */
        static void EnterNumber(out int first, out int second)
        {
            //first = 0;
            //second = 0;

            Console.Write("\nEnter 1st Number: ");
            string strFirstValue = Console.ReadLine();
            //first = int.Parse(strFirstValue);
            int.TryParse(strFirstValue, out first);

            Console.Write("\nEnter 2nd Number: ");
            string strSecondValue = Console.ReadLine();
            //second = int.Parse(strSecondValue);
            int.TryParse(strSecondValue, out second);
        }
        static void Main()
        {            
            char decision = 'n';
            do
            {
                PrintMenu();
                int userChoice;
                AskUserForChoice(out userChoice);
                Console.WriteLine($"choice:{userChoice}");

                //int firstNumber = EnterNumber();
                //int secondNumber = EnterNumber();
                int firstNumber;
                int secondNumber;
                EnterNumber(out firstNumber, out secondNumber);

                Calculate(userChoice, firstNumber, secondNumber);

                //decision = AskUserWhetherToContinueOrNot();
                AskUserWhetherToContinueOrNot(ref decision);
                decision = Converter.ConvertUpperCaseDecisionToLower(decision);                

            } while (decision != 'n');
        }
    }
}
