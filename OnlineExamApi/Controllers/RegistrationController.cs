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
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationDao registration;

        public RegistrationController(IRegistrationDao registrationDao)
        {
            this.registration = registrationDao;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var fetchedData = registration.FetchAll();
            return this.Ok(fetchedData);
        }

        [HttpPost]
        public IActionResult AddRegistration(Registration register)
        {
            var result = registration.AddOne(register);
            return this.CreatedAtAction("AddRegistration", $"{result} record added");
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetDetailsById(int id)
        {
            var fetchedData = registration.FetchOne(id);
            return this.Ok(fetchedData);
        }

    }
}
