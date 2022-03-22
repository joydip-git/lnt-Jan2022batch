using AuthService.Models;
using AuthService.Repository.Implementation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult ValidateUser([FromBody] UserInfo user)
        {
            AuthenticationDaoImpl authenticationDao = new AuthenticationDaoImpl();
            bool isAuthenticated = authenticationDao.AuthenticateUser(user);
            if (!isAuthenticated)
                return this.NotFound("User is not authenticated");
            else
            {
                //generate the unique vakue and send as response to the user
                return this.Ok("Valid User");
            }
        }

        [HttpGet]
       // [Authorize]
        public string Index()
        {
            return "welcome to asp.net core auth";
        }
    }
}
