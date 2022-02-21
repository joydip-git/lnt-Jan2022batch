using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main()
        {
            //employee emp = new employee();
            //1,2,3,4,5,6
            //array is a collection of similar type of values
            //you create an object of Array class
            //Array arr = new Array(int,5);<--do not create the object in this way
            //create the array in the following way

            //<data-type-of-values>[] <arr-var-name> = new <data-type-of-values>[<size>];

            //Array itself is a reference type
            //array of value types (stores values directly)
            int[] arr = new int[5];

            //arr[0] = 10;
            //arr[1] = 20;
            //arr[2] = 30;
            //arr[3] = 40;
            //arr[4] = 50;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"enter value at arr[{i}]: ");
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"value at arr[{i}]:{arr[i]}");
            //}
            
            //used to iterate and display all elements from a collection (such as: array), without any condition (like readonly loop)
            //it can't be used to enter values into the collection
            //during the iteration do not add or delete any value from the collection, just you can update value at an index
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }

            Product dellProduct = new Product(1, "dell xps", 100000);
            Product onePlusProduct = new Product(2, "One Plus 9", 67000);
            Product hpLaptopProduct = new Product(3, "HP Probook", 78000);

            //array of refernce types (stores references/addresses)
            Product[] products = new Product[3];

            products[0] = dellProduct;
            products[1] = onePlusProduct;
            products[2] = hpLaptopProduct;

            Console.WriteLine("\n\n");
            //for (int i = 0; i < products.Length; i++)
            //{
            //    Product productRef = products[i];
            //    Console.WriteLine($"Name:{productRef.ProductName}");
            //}

            foreach (Product p in products)
            {
                Console.WriteLine($"Name:{p.ProductName}");
            }

            Console.WriteLine("\n\n");

            //array of value types
            int[,] twoDimArr = new int[2, 3];

            for (int rowNo = 0; rowNo < 2; rowNo++)
            {
                for (int indexNo = 0; indexNo < 3; indexNo++)
                {
                    Console.Write($"enter value at twoDimArr[{rowNo},{indexNo}]: ");
                    int number = int.Parse(Console.ReadLine());
                    twoDimArr[rowNo, indexNo] = number;
                }
            }
            for (int rowNo = 0; rowNo < 2; rowNo++)
            {
                for (int indexNo = 0; indexNo < 3; indexNo++)
                {
                    Console.WriteLine($"value at twoDimArr[{rowNo},{indexNo}]: { twoDimArr[rowNo, indexNo]}");                   
                }
            }

            /*
            for (int i = 0; i < 5; i++)
            {
                SayHello();
            }
            for (int i = 5; i > 0; i--)
            {
                SayHello();
            }
            */
        }
        static void SayHello()
        {
            Console.WriteLine("hello...");
        }
    }
}
