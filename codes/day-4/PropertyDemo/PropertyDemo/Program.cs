using System;

namespace PropertyDemo
{
    class Program
    {
        static void Main()
        {
            Product dellProduct = new Product(1, "dell xps 13", 100000, "new laptop from dell");
            //Console.WriteLine(dellProduct.GetInfo());
            //Console.WriteLine(dellProduct.GetName());
            //dellProduct.SetName("dell xps 15");
            //Console.WriteLine(dellProduct.GetName());

            //calling the property an assigning (like passing value to the method) a value: calling set accessor
            dellProduct.ProductName = "dell xps 15";
            //calling the property, but not assigning any value: calling the get accessor
            Console.WriteLine(dellProduct.ProductName);

            Product onePlusNineProduct = new Product(2);

            onePlusNineProduct.ProductName = "One Plus 9";
            onePlusNineProduct.Price = 67000;
            onePlusNineProduct.Description = "New mobile from One Plus";

            Console.WriteLine(onePlusNineProduct.GetInfo());
        }
    }
}
