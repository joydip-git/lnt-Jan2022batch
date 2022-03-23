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
    public class DifficultyLevelController : ControllerBase
    {
        private readonly ILevelDao level;

        public DifficultyLevelController(ILevelDao level)
        {
            this.level = level;
        }

        [HttpGet]
        public IActionResult GetLevel()
        {
            var result = level.FetchLevel();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddLevel(Difficultylevel lev)
        {
            var result = level.AddLevel(lev);
            return this.CreatedAtAction("AddLevel", $"{result} record added");
        }
        [HttpDelete]
        public IActionResult DeleteLevel(int id)
        {
            var deleted = level.DeleteLevel(id);
            return Ok(deleted);
        }

    }
}
