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
        /*
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
           
            }
        */
        public ViewResult AddProduct()
        {
            return this.View();
        }

        public IActionResult SubmitProductData(Product newProductData)
        {
            //call AddProduct method of ProductRepository class here to add this product into database table
            ProductRepository repository = null;
            try
            {
                repository = new ProductRepository();
                var status = repository.InsertProduct(newProductData);
                if (status)
                {
                    this.ViewBag.Message = "record added successfully";
                    //return this.RedirectToAction("GetProducts");
                    return this.View("AddProduct");
                }
                else
                {
                    this.ViewBag.Message = "could not add record..try later";
                    return this.View("AddProduct");
                }
            }
            catch (Exception ex)
            {
                this.ViewBag.Message = ex.Message;
                return this.View("AddProduct");
            }
        }
    }
}
