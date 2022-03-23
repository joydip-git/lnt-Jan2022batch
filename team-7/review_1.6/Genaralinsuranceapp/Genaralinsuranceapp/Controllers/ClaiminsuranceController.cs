using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Genaralinsuranceapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaiminsuranceController : ControllerBase
    {
        private readonly IClaiminsurance objclaim;

        public ClaiminsuranceController(IClaiminsurance _objclaim)
        {
            objclaim = _objclaim;
        }

        [HttpGet("{email}")]
        public IActionResult GetPolicyByEmail(string email)
        {
            var fetchdata = objclaim.GetPolicyByEmail(email);
            return this.Ok(fetchdata);
        }

        [HttpGet]
        
        public IActionResult Getclaimreasons()
        {
            var fetchData = objclaim.Getclaimreasons();
            return this.Ok(fetchData);
        }

        [HttpPost]
        public IActionResult AddClaimdetails(Claimdata claimdata)
        {
            var result = objclaim.AddClaimdetails(claimdata);
            return this.CreatedAtAction("AddClaimdetail", $"{result} record added ");
        }



    }

}
