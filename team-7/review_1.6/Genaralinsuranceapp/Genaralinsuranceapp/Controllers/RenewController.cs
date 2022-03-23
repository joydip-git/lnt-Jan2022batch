using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Genaralinsuranceapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenewController : ControllerBase
    {
        private readonly IRenew objrenew;

        public RenewController(IRenew _objrenew)
        {
            objrenew = _objrenew;

        }

        //[HttpPut]
        //public IActionResult Updatepolicy(int id,[FromBody] Policydetails policydetails)
        //{
        //    var result = objrenew.Updatepolicy(id, policydetails);
        //    return this.CreatedAtAction("Updatepolicy(", $"{result} record added ");
        //}

        [HttpPut]
        [Route ("update")]
        public IActionResult Updatepolicy(Policydetails policydetails)
        {
            var result = objrenew.Updatepolicy(policydetails);
            return this.CreatedAtAction("Updatepolicy(", $"{result} record added ");
        }


        [HttpGet("{email}")]
        public IActionResult GetPolicyByEmail(string email)
        {
            var fetchdata = objrenew.GetPolicyByEmail(email);
            return this.Ok(fetchdata);
        }


        [HttpGet]

       public IActionResult GetAllPolicies()
        {
            var fetchData = objrenew.GetAllPolicies();
            return this.Ok(fetchData);
        }
    }
}
