using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Genaralinsuranceapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private  IRegistration objcustomer;

        public RegistrationController(IRegistration objcustomer)
        {
            this.objcustomer = objcustomer;

        }
        [HttpGet]
        [Route("all")]
        public  IActionResult GetALLCustomer()
        {
           var fetchData = objcustomer.GetALLCustomer();
            return this.Ok(fetchData);
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerRegistration customerRegistration)
        {
           var result = objcustomer.AddCustomer(customerRegistration);
            return this.CreatedAtAction("AddCustomer" , $"{result} record added ");
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerById(long id)
        {
            var fetchdata = objcustomer.GetCustomerById(id);
            return this.Ok(fetchdata);
        }

    }
}
