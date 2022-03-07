using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    //this classs stores some sample product objects and returns the same through a method
    public static class ProductRepository
    {
        private static List<Product> products;

        static ProductRepository()
        {
            products = new List<Product>
            {
                new Product { ProductId=2, ProductName="Dell XPS", Price=30000, Description="new laptop from dell"},
                new Product { ProductId=1, ProductName="Lenovo thinkpad", Price=20000, Description="new laptop from Lenovo"},
                new Product { ProductId=3, ProductName="Hp Probook", Price=10000, Description="new laptop from HP"}
            };
        }

        public static List<Product> GetProducts()
        {
            return products;
        }
    }
}
