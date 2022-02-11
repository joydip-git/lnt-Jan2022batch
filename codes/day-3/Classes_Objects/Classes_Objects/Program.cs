using System;

namespace Classes_Objects
{
    class Program
    {
        static Product AcceptProductValues()
        {
            Console.Write("enter product name: ");
            string name = Console.ReadLine();

            Console.Write("enter product id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("enter product price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("enter product description: ");
            string description = Console.ReadLine();

            //productObject is a local variable here, which will store the initial address of the object's memory blok in the heap
            //since the variable is storing the address of an object of type Product class, then the data type should be Product (class name)
            Product productObjectReference = null;

            //now by 'new Product()' you creating an object in the heap with 4 memory blocks (productId, productName, price, description) with default values (0,NULL,0,NULL)
            //by ''
            //productObject = new Product();
            //productObject.productId = id;
            //productObject.productName = name;
            //productObject.price = price;
            //productObject.description = description;

            productObjectReference = new Product(name, id, price, description);            
            return productObjectReference;
        }
        static void Main()
        {
            Product dellProductObjRef = AcceptProductValues();
            string dellProductInfo = dellProductObjRef.PrintInfo();
            Console.WriteLine(dellProductInfo);

            Product oneplusProductObjRef = AcceptProductValues();
            string oneplusProductInfo = oneplusProductObjRef.PrintInfo();
            Console.WriteLine(oneplusProductInfo);
        }
    }
}
