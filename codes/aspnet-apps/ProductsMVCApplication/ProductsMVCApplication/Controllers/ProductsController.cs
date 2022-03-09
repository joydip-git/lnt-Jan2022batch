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
        //public JsonResult GetPerson()
        //{
        //    //create an anonymous type object
        //    var personData = new { Name = "anil", Id = 1, Salary = 3000 };
        //    JsonResult jsonPersonData = this.Json(personData);
        //    return jsonPersonData;
        //}
        //public RedirectResult Index()
        //{
        //    //var redirectRoute = new { controller = "Products", action = "GetPerson" };
        //    RedirectResult redirectResult = this.Redirect("Products/GetPerson");
        //    return redirectResult;
        //}
        public ViewResult Index()
        {
            ViewResult viewResult = this.View();
            return viewResult;
        }
        public ViewResult GetProducts()
        {
            //data
            int x = 10;
            int y = 20;

            //access the ViewBag object through Controller class's property ViewBag
            var viewBagObject = this.ViewBag;
            //access the ViewDataDictionary object through Controller class's property ViewData
            var viewDataObject = this.ViewData;

            //attach a random property with viewbag object (since it is dynamic object) and assign the value (that you need to pass to the view) to that property
            viewBagObject.MyValue = x;
            //save the vakue in the ViewDataDictionary object using a key (string type)
            viewDataObject["MyData"] = y;

            //fetch sample product data from repository
            List<Product> productsData = ProductRepository.Products;
            //pass the data to the view
            //you can pass List<Product> type data to the View method if the view (GetProducts.cshtml file) is bound to the same type of model (List<Product>)
            ViewResult result = this.View(productsData);

            //return the view with data as response
            return result;
        }
        /*
        public IActionResult GetProduct(int arg = 1)
        {
            List<Product> allProducts = ProductRepository.Products;
            //var query = from p in allProducts
            //            where p.ProductId == arg
            //            select p;
            var all = allProducts.Where(p => p.ProductId == arg);
            Product found = null;
            if (all != null && all.Count() > 0)
            {
                found = all.First();
            }

            //either we are returning JsonResult or NotFoundObjectResult
            if (found != null)
                return this.Json(found);
            else
                return this.NotFound("No record found"); 
        }
        */
        public IActionResult GetProduct(int arg = 1)
        {
            List<Product> allProducts = ProductRepository.Products;
            //var query = from p in allProducts
            //            where p.ProductId == arg
            //            select p;
            var all = allProducts.Where(p => p.ProductId == arg);
            Product found = null;
            if (all != null && all.Count() > 0)
            {
                found = all.First();
            }

            //either we are returning JsonResult or NotFoundObjectResult
            if (found != null)
                return this.View(found);
            else
                return this.NotFound("No record found");
        }
    }
}
