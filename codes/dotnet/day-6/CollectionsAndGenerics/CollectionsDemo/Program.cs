using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        static void Main()
        {
            /*
            int[] arr = new int[] { 1, 2, 3 };

            //Length property of the array gives you the size of the array
            int[] temp = new int[arr.Length];
            arr.CopyTo(temp, 0);
           
            arr = new int[4];
            Array.Copy(temp, arr, temp.Length);
            arr[arr.Length-1]= 4;

            temp = null;
            */

            //int[] arr = new int[2];
            //arr[0] = 10;

            //Array, built-in class, is an abstract class
            //You can not create object of that class
            //Array arr = new Array();

            //object or Object

            //Value type --> Reference Type (Boxing)
            //implicit conversion
            //value type variable (numVal)
            int numVal = 12;
            //rference type variable (intVal)
            object intVal = numVal;

            //that refernce type to same value type (unboxing)
            //explicit conversion
            int x = (int)intVal;

            double fractionalVal = 12.34;
            Object doubleVal = fractionalVal;
            Object strVal = "LnT";
            Object charVal = 'a';

            //collection class: ArrayList
            //advantages:
            //no size restriction
            //dynamic, keep on adding or removing value, the collection will be resized

            //disadvantages:
            //all the values of different type are boxed into object type, which is time consuimg
            //when you iterate the values from the collection, the values will be unboxed again
            //since all the elements are of Object type now, they are hard to sort, because down-the-line they are all of different data types
            ArrayList al = new ArrayList();
            int a = 1;
            object aVal = a;
            al.Add(aVal);
            //al.Add(1);
            al.Add('a');
            al.Add(12.34);
            al.Add("LnT");
            //Count property gives the number of elements currently in the collection
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            Console.WriteLine("\n\n");
            al.Remove(12.34);
            foreach (object item in al)
            {
                Console.WriteLine(item);
            }

            //int[] arr = new int[] { 4, 1, 2, 3 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            Console.WriteLine("\n\n");

            //generic collection class
            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(12);
            numberList.Add(5);
            numberList.Add(5);
            numberList.Add('a');

            numberList.Sort();
            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }
            Console.WriteLine("\n");
            numberList.Remove('a');
            foreach (int item in numberList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");
            List<string> names = new List<string>();
            names.Add("Akash"); //0
            names.Add("Swapnil");//1
            //the insertion index value <= Count property value [0 --> 2]
            names.Insert(2, "Deepthi");
            //names.InsertRange(1,new List<string> {"", "",""});
            names.Sort();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");
            names.RemoveAt(1);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            //names.RemoveRange(0, 2);            
        }
    }
}
