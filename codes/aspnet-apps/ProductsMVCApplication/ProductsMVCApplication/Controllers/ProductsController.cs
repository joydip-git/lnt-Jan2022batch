﻿using Microsoft.AspNetCore.Mvc;
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
            ProductRepository repository = null;
            try
            {
                repository = new ProductRepository();
                List<Product> productsData = repository.FetchAllProducts();
                ViewResult result = this.View(productsData);
                return result;
            }
            catch (Exception ex)
            {
                this.ViewBag.Error = ex.Message;
                return this.View(null);
            }
        }
        /*
        public IActionResult GetProduct(int arg = 1)
        {
           
           
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
