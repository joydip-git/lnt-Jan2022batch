using System;
using System.Collections.Generic;

namespace OtherGenericClasses
{
    class Program
    {
        static void Main()
        {
            //this collection allows only unique values to be added
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(12);
            set.Add(1);
            set.Add(13);

            foreach (int item in set)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            set.Remove(12);
            foreach (int item in set)
            {
                Console.WriteLine(item);
            }

            //keys should be unique, whereas values could be duplicate
            //Dictionary is similar to HashTable class in System.Collections
            //HashTable hash = new HashTable();
            //hash.Add(1,"");
            //hash.Add('a',12.34);
            /*
             * foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
             */

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Deepthi"); //KeyValuePair<int,str>
            keyValuePairs.Add(0, "Giri");
            keyValuePairs.Add(2, "Mansi");
            //this line will throw exception, since you are using the duplicate key
            //Add method is used to just add a key value pair, NOT TO UPDATE value of existing key
            //keyValuePairs.Add(2, "Abhishek");
            Console.WriteLine("\n\n");
            foreach (KeyValuePair<int, string> item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            keyValuePairs.Remove(1);
            Console.WriteLine("\n");
            foreach (KeyValuePair<int, string> item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            //updating the existing value of the given key
            keyValuePairs[2] = "Abhishek";

            //since the key does not exist, the key as well as the value will be added in the collection
            keyValuePairs[3] = "Adanki";
            Console.WriteLine("\n");
            foreach (KeyValuePair<int, string> item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            //SortedList<> is similar to SortedList class in System.Collections
            //SortedList sl = new SortedList();
            //make sure the keys are of similar type (required for sorting the keys)
            //sl.Add(1,"");
            //sl.Add(0,12.34);
            /*
             * foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
             */

            //difference with Dictionary is: Dictionary<> does not sort the keys, whereas SortedList<> sorts the keys
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(1, "Deepthi"); //KeyValuePair<int,str>
            sortedList.Add(0, "Giri");
            sortedList.Add(2, "Mansi");
            //this line will throw exception, since you are using the duplicate key
            //Add method is used to just add a key value pair, NOT TO UPDATE value of existing key
            //sortedList.Add(2, "Abhishek");
            Console.WriteLine("\n\n");
            foreach (KeyValuePair<int, string> item in sortedList)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            sortedList.Remove(1);
            Console.WriteLine("\n");
            foreach (KeyValuePair<int, string> item in sortedList)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            //updating the existing value of the given key
            sortedList[2] = "Abhishek";

            //since the key does not exist, the key as well as the value will be added in the collection
            sortedList[3] = "Adanki";
            Console.WriteLine("\n");
            foreach (KeyValuePair<int, string> item in sortedList)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }
}
