using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DummyProject.DataAccessLayer.Repository.Implementation;
using DummyProject.DataAccessLayer.Repository.Abstraction;
using DummyProject.BusinessModels;

namespace DummyProject.ProductServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductDao _productDao;

        public ProductController(IProductDao productDao)
        {
            _productDao = productDao;
        }

        [HttpGet]
        [Route("home")]
        public string Index()
        {
            return "Welcome to Products Service API";
        }

        [HttpGet]
        [Route("allproducts")]
        public IActionResult FetchProducts()
        {
            try
            {
                //ProductDaoImpl productDaoImpl = new ProductDaoImpl();
                return this.Ok(_productDao.GetAll());
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertProduct(ProductModel product)
        {
            if (this.ModelState.IsValid)
            {
                _productDao.Add(product);
            }
            return null;
        }
    }
}
