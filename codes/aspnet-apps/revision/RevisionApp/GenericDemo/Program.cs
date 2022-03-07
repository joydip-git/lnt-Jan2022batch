using System;

namespace GenericDemo
{
    //delegate int CalDelInteger(int a, int b);
    //delegate double CalDelDouble(double a, double b);
    //delegate TResult CalDel<in T, out TResult>(T a, T b);
    delegate T CalDel<T>(T a, T b);
    delegate bool FilterDel<in T>(T value);
    delegate void Invoke();
    delegate void Invoke<in T>(T arg);
    class Program
    {   
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static bool DoesExist(string str)
        {
            return str.Contains('a');
        }
        static int AddIntegers(int x, int y)
        {
            return (x + y);
        }
        static double AddDoubles(double x, double y)
        {
            return (x + y);
        }

        static void Main()
        {
            FilterDel<int> evenDel = new FilterDel<int>(Program.IsEven);
            FilterDel<int> oddDel = (num) => num % 2 != 0;
            FilterDel<string> aExistsDel = new FilterDel<string>(Program.DoesExist);
            Invoke<int> printDel = (num) => Console.WriteLine(num);
            Invoke helloDel = () => Console.WriteLine("hello world");

            //CalDelInteger cd = new CalDelInteger(Program.AddIntegers);
            //CalDelDouble cd1 = new CalDelDouble(Program.AddDoubles);
            CalDel<int> cd1 = new CalDel<int>(Program.AddIntegers);
            CalDel<double> cd2 = new CalDel<double>(Program.AddDoubles);

            Calculation calc = new Calculation();
            //calc.Add<int>(12, 13);
            //calc.Add<double>(12.34, 14.56);
            //calc.Add("joy", "dip");
            calc.Add<MathStudent>(new MathStudent(), new MathStudent());
            calc.Add<int, int>(10, 20);
            calc.Add<double, decimal>(10.45D, 10.56M);

            //upcasting: creating object of child class (StudentDataAccess) and storing the reference in a variable of base class/interface (CommonDataAccess<Student>/ IDataAccess<Student>)
            //CommonDataAccess<Student> studentDataAccess = new StudentDataAccess();
            IDataAccess<Student> studentDataAccess = null;
            studentDataAccess = new StudentDataAccess();
        }
    }
}
