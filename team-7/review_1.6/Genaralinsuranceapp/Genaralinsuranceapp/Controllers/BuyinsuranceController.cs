 using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Genaralinsuranceapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyinsuranceController : ControllerBase
    {
        private readonly IBuyinsurance objbuyinsurance;

        public BuyinsuranceController(IBuyinsurance _objbuyinsurance)
        {
            objbuyinsurance = _objbuyinsurance;
        }

        [HttpPost]
        public IActionResult AddInsurance(Vehiclesdetails vehiclesdetails)
        {
            var result = objbuyinsurance.AddInsurance(vehiclesdetails);
            return this.CreatedAtAction("AddInsurance", $"{result} record added ");
        }

        [HttpGet]
        public IActionResult GetPlans()
        { 
            var plan = objbuyinsurance.GetPlans();
            return this.Ok(plan); ;
        
        }
        [HttpPost]
        [Route("plan/{email}")]
        public IActionResult AddPolicy([FromBody]Policydetails policydetails, [FromRoute]string email)
        {           
            var result = objbuyinsurance.AddPolicy(policydetails, email);
            return this.CreatedAtAction("AddPolicy", $"{result} record added ");
        }



        [HttpGet]
        [Route("all")]
        public IActionResult GetDuration()
        {
            var year = objbuyinsurance.GetDuration();
            return this.Ok(year); ;

        }

        [HttpGet("{id}")]
        public IActionResult GetInsuranceById(int id)
        {
            var fetchdata = objbuyinsurance.GetInsuranceById(id);
            return this.Ok(fetchdata);
        }


        [HttpGet]
        [Route("vehicletypes")]
        public IActionResult GetVehicleTypes()
        {
            var fetchData = objbuyinsurance.GetVehicletypes();
            return this.Ok(fetchData);
        }
    }
   
}
