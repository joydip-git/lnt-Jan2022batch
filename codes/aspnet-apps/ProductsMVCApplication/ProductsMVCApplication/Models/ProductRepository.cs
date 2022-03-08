using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsMVCApplication.Models
{
    public static class ProductRepository
    {
        public static List<Product> Products =>
            new List<Product>
            {
                new Product { ProductId=2, ProductName="Dell XPS 15", Price=67000, Description="New laptop from dell"},
                new Product { ProductId=1, ProductName="HP Probook", Price=53000, Description="New laptop from HP"},
                new Product { ProductId=3, ProductName="Lenovo Thinkpad", Price=35000, Description="New laptop from Lenovo"},
            };

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
