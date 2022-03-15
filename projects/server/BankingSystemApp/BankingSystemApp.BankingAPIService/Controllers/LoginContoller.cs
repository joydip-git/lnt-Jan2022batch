using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemApp.BankingAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginContoller : ControllerBase
    {
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(string username,string password)
        {
            return null;
        }
    }
}
