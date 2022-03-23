using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineExamSystemApp.Models;
using OnlineExamSystemApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamSystemApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private ILoginDao login;

        public LoginController(ILoginDao login)
        {
            this.login = login;
        }
    }
}
