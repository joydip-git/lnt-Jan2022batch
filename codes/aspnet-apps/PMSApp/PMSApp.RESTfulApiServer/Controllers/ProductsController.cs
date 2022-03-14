using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMSApp.RESTfulApiServer.Models;
using PMSApp.RESTfulApiServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMSApp.RESTfulApiServer.Controllers
{
    //atrributed routing
    [Route("productsapi/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProduct(int id)
        {
            ProductDaoImpl productDao = new ProductDaoImpl();
            var fetchedData = productDao.FetchOne(id);
            return this.Ok(fetchedData);
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            ProductDaoImpl productDao = new ProductDaoImpl();
            var fetchedData = productDao.FetchAll();
            return this.Ok(fetchedData);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            ProductDaoImpl productDao = new ProductDaoImpl();
            var result = productDao.AddOne(product);
            return this.CreatedAtAction("AddProduct", $"{result} record added");
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            return null;
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return null;
        }

        [HttpGet]
        [Route("filter/{name}")]
        public IActionResult FilterProductsByName(string name)
        {
            ProductDaoImpl productDao = new ProductDaoImpl();
            var fetchedData = productDao.Filter(name);
            return this.Ok(fetchedData);
        }
    }
}
