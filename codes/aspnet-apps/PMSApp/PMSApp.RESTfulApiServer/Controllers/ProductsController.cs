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
        private IProductDaoImpl productDao;
        public ProductsController(IProductDaoImpl productDaoImpl)
        {
            Console.WriteLine("controller created...");
            this.productDao = productDaoImpl;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProduct(int id)
        {
            var fetchedData = productDao.FetchOne(id);
            return this.Ok(fetchedData);
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var fetchedData = productDao.FetchAll();
            return this.Ok(fetchedData);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            var result = productDao.AddOne(product);
            return this.CreatedAtAction(
                "AddProduct",
                new
                {
                    StatusCode = 201,
                    Response = result,
                    Data = product
                }
                );
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
            var fetchedData = productDao.Filter(name);
            return this.Ok(fetchedData);
        }
    }
}
