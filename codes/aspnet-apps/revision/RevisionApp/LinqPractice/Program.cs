using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqPractice
{
    class Program
    {
        static void Main()
        {
            //fetch all the products from product repository
            var allProducts = ProductRepository.GetProducts();

            //write a linq query (using both query operator syntax and method query syntax) to filter the product objects where the product price is more than 1000
            //foreach(var p in allProducts)
            var filteredProducts = (from p in allProducts
                                    where p.Price > 10000
                                    orderby p.ProductName
                                    select p).ToList<Product>();

            Func<Product, bool> filterDel = p => p.Price > 10000;
            Func<Product, string> sortDel = p => p.ProductName;
            //var filteredProductsAgain = allProducts.Where(filterDel);
            var filteredProductsAgain =
                allProducts
                .Where((p) => p.Price > 10000)
                .OrderBy(p => p.ProductName)
                .ToList<Product>();

            filteredProductsAgain.ForEach(p => Console.WriteLine(p.ToString()));
            filteredProducts.ForEach(p => Console.WriteLine(p));
        }
    }
}
