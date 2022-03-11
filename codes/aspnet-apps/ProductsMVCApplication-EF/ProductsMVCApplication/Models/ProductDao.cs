using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductsMVCApplication.Repository;

namespace ProductsMVCApplication.Models
{
    public class ProductDao
    {
        public ProductDao()
        {

        }

        //method to add new product into database table
        public bool InsertProduct(Product businessProductObj)
        {
            int result = 0;
            try
            {
                using (var db = new appdbContext())
                {
                    DbSet<Products> allProducts = db.Products;
                    Products entityModelObject = new Products
                    {
                        Productid = businessProductObj.ProductId,
                        Productname = businessProductObj.ProductName,
                        Price = businessProductObj.Price,
                        Description = businessProductObj.Description
                    };
                    allProducts.Add(entityModelObject);
                    result = db.SaveChanges();
                }
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //method to fetch all product records from the database table
        public List<Product> FetchAllProducts()
        {
            List<Product> businessProducts = null;
            try
            {
                using (var db = new appdbContext())
                {
                    DbSet<Products> allProducts = db.Products;
                    if (allProducts.Count() > 0)
                    {
                        businessProducts =
                            allProducts
                             .Select(
                                (Products p) =>
                                     new Product
                                     {
                                         ProductId = p.Productid,
                                         ProductName = p.Productname,
                                         Price = p.Price.Value,
                                         Description = p.Description
                                     }
                             )
                             .ToList<Product>();
                        //businessProducts = new List<Product>();
                        //foreach (Products p in allProducts)
                        //{
                        //    Product product = new Product
                        //    {
                        //        ProductId = p.Productid,
                        //        ProductName = p.Productname,
                        //        Price = p.Price.Value,
                        //        Description = p.Description
                        //    };
                        //    businessProducts.Add(product);
                        //}
                    }
                }
                return businessProducts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //method to fecth a single product record from database table, given the id of the product
        public Product FetchProductById(int id)
        {
            Product businessProduct = null;
            try
            {
                using (var db = new appdbContext())
                {
                    DbSet<Products> allProducts = db.Products;
                    var matchingProducts = allProducts.Where(p => p.Productid == id);
                    if (matchingProducts != null && matchingProducts.Count() > 0)
                    {
                        Products product = matchingProducts.First<Products>();
                        businessProduct = new Product
                        {
                            ProductId = product.Productid,
                            ProductName = product.Productname,
                            Price = product.Price.Value,
                            Description = product.Description
                        };
                    }
                }
                return businessProduct;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
