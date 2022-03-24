using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing; 
using Finance_Management.Repository;
using Finance_Management.DataAccessLayer;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace Finance_Management.DataAccessLayer
{
    public class ProductsDao
    {
        private FinancedbContext db;
        public ProductsDao(FinancedbContext financeDbContext)
        {
            db = financeDbContext;
        }

        public Products FetchbyId(int id)
        {
            return db.Products.Where(p => p.ProductId == id).First<Products>();
        }

        //public List<Products> GetAll()
        //{
        //    List<Products> allBusinessProducts = null;
        //    try
        //    {
        //        using (var db = new FinancedbContext())
        //        {
        //            DbSet<Products> allEntityProducts = db.Products;
        //            allBusinessProducts = allEntityProducts
        //              .Select(entityProduct =>
        //          new Products
        //          {
        //              ProductId = entityProduct.ProductId,
        //              Name = entityProduct.Name,
        //              Price = entityProduct.Price.Value,
        //               Status = entityProduct.Status,
        //              Image = entityProduct.Image,

        //          })
        //              .ToList<Products>();
        //        }
        //        return allBusinessProducts;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
