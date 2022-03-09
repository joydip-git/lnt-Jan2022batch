using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingASPNETCore.Controllers
{
    //[Route("{controller}")]
    public class HomeController : Controller
    {
        //R1: Home/Index
        //[Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        //R2: Home/Get
        public IActionResult Get(int id)
        {
            return this.Json(new { Name = "anil", Id = 1, Salary = 1000 });
        }

        //R3: Home/GetAll
        public IActionResult GetAll()
        {
            //implictly typed array
            var arr = new[] {
                new { Name = "anil", Id = 1, Salary = 1000 },
                new { Name = "sunil", Id = 2, Salary = 2000 }
            };
            return this.Json(arr);
        }
    }
}
