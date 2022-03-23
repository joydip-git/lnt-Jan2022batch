using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineExamSystemApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamSystemApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExamCatagoryController : ControllerBase
    {        

        [HttpGet]
        public IEnumerable<Examcategory> Get()
        {
            return null;
        }
    }
}
