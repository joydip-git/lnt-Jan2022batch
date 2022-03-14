using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetProduct()
        {
            return null;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            return null;
        }
    }
}
