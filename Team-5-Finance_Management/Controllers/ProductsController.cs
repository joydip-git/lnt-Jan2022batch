using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
 
using Finance_Management.Repository;
using Finance_Management.DataAccessLayer;
using System;

namespace Finance_Management.DataAccessLayer
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private IProducts db;

        public ProductsController(IProducts db)
        {
            this.db = db;
        }





        [HttpGet]
        [Route("fetchById")]
        //[HttpGet]
        //[Route("fetchById")]

        public IActionResult FetchbyId(int id)
        {
            var fetchedData = db.FetchbyId();
            return Ok(fetchedData);
        }
    }
}
