using DummyProject.BusinessModels;
using DummyProject.DataAccessLayer.Models;
using DummyProject.DataAccessLayer.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DummyProject.DataAccessLayer.Repository.Implementation
{
    public class ProductDaoImpl : IProductDao
    {
        public int Add(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProductModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAll()
        {
            List<ProductModel> allBusinessProducts = null;
            try
            {
                using (var db = new productsdbContext())
                {
                    DbSet<Products> allEntityProducts = db.Products;
                    allBusinessProducts = allEntityProducts
                      .Select(entityProduct =>
                  new ProductModel
                  {
                      ProductId = entityProduct.Productid,
                      ProductName = entityProduct.Productname,
                      Price = entityProduct.Price.Value,
                      Description = entityProduct.Description,
                      ImagePath = entityProduct.Imagepath,
                      StarRating = entityProduct.Starrating.Value,
                      ReleasedDate = entityProduct.Releaseddate.Value
                  })
                      .ToList<ProductModel>();
                }
                return allBusinessProducts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Udate(int id)
        {
            throw new NotImplementedException();
        }
    }
}
