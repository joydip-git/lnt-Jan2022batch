using PMSApp.RESTfulApiServer.Models;
using System.Collections.Generic;
using System.Linq;

namespace PMSApp.RESTfulApiServer.Repository
{
    public class ProductDaoImpl : IProductDaoImpl
    {
        private ProductsDbContext db;
        public ProductDaoImpl(ProductsDbContext productsDbContext)
        {
            this.db = productsDbContext;
            System.Console.WriteLine("dao created");
        }
        public List<Product> FetchAll()
        {
            //using (var db = new ProductsDbContext())
            //using (this.db)
            //{
            //    return db.Products.ToList<Product>();
            //}
            return db.Products.ToList<Product>();
        }
        public Product FetchOne(int id)
        {
            //using (var db = new ProductsDbContext())
            //using (this.db)
            //{
            //    return db.Products.Where(p => p.ProductId == id).First<Product>();
            //}
            return db.Products.Where(p => p.ProductId == id).First<Product>();
        }
        public int AddOne(Product product)
        {
            //using (this.db)
            //{
            //    db.Products.Add(product);
            //    return db.SaveChanges();
            //}
            db.Products.Add(product);
            return db.SaveChanges();
        }
        public List<Product> Filter(string productName)
        {
            //using (this.db)
            //{
            //    return db.Products.Where(p => p.ProductName.Contains(productName)).ToList<Product>();
            //}
            return db.Products.Where(p => p.ProductName.Contains(productName)).ToList<Product>();
        }
    }
}
