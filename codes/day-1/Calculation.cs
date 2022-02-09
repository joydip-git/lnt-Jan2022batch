using System;

class Calculation
{
	static void Main()
	{
		Add();
		Subtract();
	}
	static void Add()
	{
		//1. accept first number from user and convert it to number format
		Console.WriteLine("enter 1st number");
		string first = Console.ReadLine(); //12--> "12"
		int firstValue = int.Parse(first);

		//2. accept second number from user and convert it to number format
		Console.WriteLine("enter 2nd number");
		string second = Console.ReadLine(); //12--> "12"
		int secondValue = int.Parse(second);

		//3. add those two numbers
		int res = firstValue+secondValue;

		//4. print the result of addition on the screen
		Console.WriteLine(res);
	}
	static void Subtract()
	{
		//1. accept first number from user and convert it to number format
		Console.WriteLine("enter 1st number");
		string first = Console.ReadLine(); //12--> "12"
		int firstValue = int.Parse(first);

		//2. accept second number from user and convert it to number format
		Console.WriteLine("enter 2nd number");
		string second = Console.ReadLine(); //12--> "12"
		int secondValue = int.Parse(second);

		//3. subtract those two numbers
		int res = firstValue-secondValue;

		//4. print the result of subtraction on the screen
		Console.WriteLine(res);
	}
}