using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsMVCApplication.Models;

namespace ProductsMVCApplication.Controllers
{
    public class ProductsController : Controller
    {
        public ViewResult Index()
        {
            ViewResult viewResult = this.View();
            return viewResult;
        }
        
        public ViewResult GetProducts()
        {
            //call GetProducts method of ProductRepository class here to fetch all product details from the database table
            ProductRepository repository = new ProductRepository();
            repository.FetchAllProducts();
            //List<Product> productsData = ProductRepository.Products;
            //ViewResult result = this.View(productsData);
            //return result;
            return this.View();
        }
        
        public IActionResult GetProduct(int arg = 1)
        {
            //call GetProductById method of ProductRepository class here to fetch this product details from the database table, by supplying the id
            ProductRepository repository = new ProductRepository();
            repository.FetchProductById(arg);
            return this.View();
            /*
            var all = allProducts.Where(p => p.ProductId == arg);
            Product found = null;
            if (all != null && all.Count() > 0)
            {
                found = all.First();
            }

            if (found != null)
                return this.View(found);
            else
                return this.NotFound("No record found");
            */
        }
       
        public ViewResult AddProduct()
        {
            return this.View();
        }

        public IActionResult SubmitProductData(Product newProductData)
        {
            //call AddProduct method of ProductRepository class here to add this product into database table
            ProductRepository repository = new ProductRepository();
            repository.InsertProduct(newProductData);
            //var allProducts = ProductRepository.Products;
            //var found = allProducts.Where(p => p.ProductId == newProductData.ProductId);
            //if (found != null && found.Count() > 0)
            //{
            //    string errorMessage = "The product exists";
            //    this.ViewBag.Error = errorMessage;
            //    return this.View("AddProduct");
            //}
            //else
            //    ProductRepository.Add(newProductData);

            //return this.RedirectToAction("GetProducts");
            return View();
        }
    }
}
