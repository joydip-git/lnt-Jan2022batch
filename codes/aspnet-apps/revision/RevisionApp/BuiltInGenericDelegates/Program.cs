using System;
using System.Collections.Generic;
using System.Linq;

namespace BuiltInGenericDelegates
{
    class Program
    {
        static void Main()
        {
            //non-generic: public delegate void Action();
            Action printDel = delegate ()
              {
                  Console.WriteLine("hello world");
              };
            printDel();

            //generic: public delegate void Action<in T>(T obj);
            Action<string> printStringDel = delegate (string message)
            {
                Console.WriteLine(message);
            };

            printStringDel("hello world");

            //collection intializer (C# 3.0 - 2007)
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //variable declared with var keyword is known as implicitly declared variable (such as item)
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //    //what to do with that item????
            //}

            //LINQ: Language (L) Integrated(IN) Query (Q)
            //technique to query a source of data
            //LINQ is applied on collections
            //SQL query: select [column-names] from [table-name]

            //Action<int> printNumDel = delegate (int num) { Console.WriteLine(num); }
            Action<int> printNumDel = (num) => Console.WriteLine(num);
            //LINQ: Method syntax
            numbers.ForEach(printNumDel);
            Console.WriteLine("\n\n");


            //LINQ: Query syntax
            //from <var-name> in <source-of-data>
            //var-nane=> range variable (represents a value from the range of values in collection)
            //from num in numbers => equivalent to foreach loop
            //every collection/generic collection class implements IEnumerable<T> interface
            //IEnumerable<int> queryResult = from num in numbers
            //                               where num % 2 == 0
            //                               orderby num descending
            //                               select num;

            //Method syntax
            //public delegate TResult Func<in T, out TResult>(T obj);
            //Func<int, bool> evenDel = (num) => num % 2 == 0;

            //where method accepts reference to a function (logic) through a Func<> delegate
            //IEnumerable<int> evenResult = numbers.Where(evenDel);

            //Func<int, int> orderByDel = (num) => num;
            //IEnumerable<int> orderedEvenResult = evenResult.OrderByDescending(orderByDel);

            IEnumerable<int> orderedEvenResult =
                numbers
                .Where(num => num % 2 == 0)
                .OrderByDescending(num => num);

            foreach (var item in orderedEvenResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
