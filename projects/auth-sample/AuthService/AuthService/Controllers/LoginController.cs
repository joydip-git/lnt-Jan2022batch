using AuthService.Models;
using AuthService.Repository.Implementation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace AuthService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration configuration;
        public LoginController(IConfiguration _configuration)
        {
            this.configuration = _configuration;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult ValidateUser([FromBody] UserInfo user)
        {
            AuthenticationDaoImpl authenticationDao = new AuthenticationDaoImpl();
            bool isAuthenticated = authenticationDao.AuthenticateUser(user);
            if (!isAuthenticated)
                return this.NotFound("User is not authenticated");

            //generate the Jwt and send as response to the user
            //get the secret key from appsettings.json file and convert it inot a byte array
            var tokenValue = GenerateJwt(user);
            return this.Ok(new { token = tokenValue });

        }

        [HttpGet]
        //[Authorize]
        public string Index()
        {
            var headerValue = HttpContext.Request.Headers["Authorization"];
            var arrOfStrings = headerValue.ToString().Split(' ');
            var token = arrOfStrings[1];
            return "welcome to asp.net core auth " + token;
            //return "welcome to asp.net core auth";
        }

        //[Authorize]
        [HttpGet]
        [Route("values")]
        public ActionResult<string[]> GetValues()
        {
            return new string[] { "Joydip", "Priya" };
        }

        private string GenerateJwt(UserInfo user)
        {
            string secretKey = this.configuration["Jwt:Key"];
            byte[] secrectKeyByteArray = Encoding.UTF8.GetBytes(secretKey);
            SymmetricSecurityKey tokenKey = new SymmetricSecurityKey(secrectKeyByteArray);
            SigningCredentials signingCredentials = new SigningCredentials(tokenKey, SecurityAlgorithms.HmacSha256);

            Claim userNameBasedClaim = new Claim(ClaimTypes.Name, user.UserName);
            Claim[] userClaims = new Claim[] { userNameBasedClaim };
            ClaimsIdentity identiy = new ClaimsIdentity(userClaims);
            SecurityTokenDescriptor tokeDescriptor = new SecurityTokenDescriptor
            {
                Subject = identiy,
                Expires = DateTime.Now.AddMinutes(5),
                SigningCredentials = signingCredentials
            };
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken = tokenHandler.CreateToken(tokeDescriptor);
            string token = tokenHandler.WriteToken(securityToken);
            return token;
        }
        private void ValidateJwt()
        {

        }
    }
}
