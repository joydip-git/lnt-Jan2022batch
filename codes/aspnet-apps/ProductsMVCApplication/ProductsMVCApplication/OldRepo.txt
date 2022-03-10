using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsMVCApplication.Models
{
    public static class ProductRepository
    {
        private static List<Product> products;
        static ProductRepository()
        {
            products = new List<Product>
            {
                new Product { ProductId=2, ProductName="Dell XPS 15", Price=67000, Description="New laptop from dell"},
                new Product { ProductId=1, ProductName="HP Probook", Price=53000, Description="New laptop from HP"},
                new Product { ProductId=3, ProductName="Lenovo Thinkpad", Price=35000, Description="New laptop from Lenovo"},
            };
        }
        public static List<Product> Products => products;

        public static void Add(Product newData)
        {
            products.Add(newData);
        }
            

        /*
         public static List<Product> Products
        {
            get
            {
                return new List<Product>
            {
                new Product { ProductId=2, ProductName="Dell XPS 15", Price=67000, Description="New laptop from dell"},
                new Product { ProductId=1, ProductName="HP Probook", Price=53000, Description="New laptop from HP"},
                new Product { ProductId=3, ProductName="Lenovo Thinkpad", Price=35000, Description="New laptop from Lenovo"},
            };
            }
        }
         */
    }
}
