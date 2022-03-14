using PMSApp.RESTfulApiServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMSApp.RESTfulApiServer.Repository
{
    public class ProductDaoImpl
    {
        public List<Product> FetchAll()
        {
            using (var db = new ProductsDbContext())
            {
                return db.Products.ToList<Product>();
            }
        }
        public Product FetchOne(int id)
        {
            using (var db = new ProductsDbContext())
            {
                return db.Products.Where(p => p.ProductId == id).First<Product>();
            }
        }
        public int AddOne(Product product)
        {
            using (var db = new ProductsDbContext())
            {
                db.Products.Add(product);
                return db.SaveChanges();
            }
        }
        public List<Product> Filter(string productName)
        {
            using (var db = new ProductsDbContext())
            {
                return db.Products.Where(p => p.ProductName.Contains(productName)).ToList<Product>();
            }
        }
    }
}
