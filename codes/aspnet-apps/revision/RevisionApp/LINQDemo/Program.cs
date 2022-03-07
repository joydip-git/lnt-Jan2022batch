using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main()
        {
            //trying to filter a collection of integer values and sort that in desccending order
            List<int> numbers = new List<int> { 1, 4, 2, 5, 6, 3, 8, 0, 7, 9 };

            //1. filtering the even numbers
            //the method comes from System.Linq namespace. this extension method is then added to the methods of List<T> generic collection class
            //this method is used to filter any collection based on the logic that you pass to the method as argument
            //the logic is passed via Func<> delegate
            Func<int, bool> evenDel = num => num % 2 == 0;
            IEnumerable<int> evenNumbers = numbers.Where(evenDel);

            //2. sorting the result set in descending order
            //the method comes from System.Linq namespace. this extension method is then added to the methods of List<T> generic collection class
            //this method is used to sort the items of any collection in descending order, based on your logic
            //the logic is passed via Func<> delegate
            Func<int, int> orderByDel = (num) => num;
            IEnumerable<int> orderedEvenNumbers = evenNumbers.OrderByDescending(orderByDel);

            //3. creating particularly a List<T> object to store the results
            //the method comes from System.Linq namespace. this extension method is then added to the methods of List<T> generic collection class
            //this method is used to convert a result set into a List<T> object
            List<int> orderedEvenNumberList = orderedEvenNumbers.ToList<int>();

            //4. print the values from the List<T> object storing the results
            //Action<T> is used to create a logic about what to do with an item            
            //ForEach() method wants to know what to do with every item in the collection
            //pass an object of Action<T> containing logic about what to do with every item in the collection
            Action<int> printAction = (num) => Console.WriteLine(num);
            orderedEvenNumberList.ForEach(printAction);

            Console.WriteLine("\n\n");

            //the above parts can be written in single line           
            numbers
                .Where(num => num % 2 == 0)
                .OrderByDescending(num => num)
                .ToList<int>()
                .ForEach(num => Console.WriteLine(num));

            Console.WriteLine("\n\n");
            //the same can be written in query operator syntax (upto order by descending)
            var query = from num in numbers
                        where num % 2 == 0
                        orderby num descending
                        select num;

            query.ToList<int>().ForEach(num => Console.WriteLine(num));


            /*
            List<int> evenNumbers = new List<int>();
            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                    evenNumbers.Add(item);
            }

            for (int i = 0; i < evenNumbers.Count; i++)
            {
                for (int j = i + 1; j < evenNumbers.Count; j++)
                {
                    if (evenNumbers[i] < evenNumbers[j])
                    {
                        int temp = evenNumbers[i];
                        evenNumbers[i] = evenNumbers[j];
                        evenNumbers[j] = temp;
                    }
                }
            }

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
            */
            Console.WriteLine("\n\n");
            //group the collection by first letter of the names of the places
            List<string> names = new List<string> { "mumbai", "bangalore", "mangalore", "baroda", "chennai", "coimbatore" };

            var nameGroups = from name in names
                             orderby name ascending
                             group name by name[0];

            foreach (var group in nameGroups)
            {
                Console.WriteLine($"First Letter: {group.Key}");
                Console.WriteLine("--------------------------");
                foreach (var name in group)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n\n");
            //Func<string, char> groupDel = (name) => name[0];
            //var groups = names.OrderBy(name => name).GroupBy(groupDel);
            var groups = names.OrderBy(name => name).GroupBy(name => name[0]);
            foreach (var group in groups)
            {
                Console.WriteLine($"First Letter: {group.Key}");
                Console.WriteLine("--------------------------");
                foreach (var name in group)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("\n");
            }
            //names.Sort();
            /*
            SortedList<char, List<string>> nameGropus = new SortedList<char, List<string>>();
            foreach (var name in names)
            {
                char firstLetter = name[0];
                if (nameGropus.ContainsKey(firstLetter))
                {
                    var list = nameGropus[firstLetter];
                    list.Add(name);
                }
                else
                {
                    //var list = new List<string>();
                    //list.Add(name);
                    //nameGropus.Add(firstLetter, list);
                    nameGropus.Add(firstLetter, new List<string> { name });
                }
            }

            foreach (KeyValuePair<char, List<string>> item in nameGropus)
            {
                Console.WriteLine($"First Letter: {item.Key}");
                Console.WriteLine("--------------------------");
                var list = item.Value;
                foreach (var name in list)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("\n");
            }
            */
        }
    }
}
