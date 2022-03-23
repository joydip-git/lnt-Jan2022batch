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
    public class CorrectAnswerController : ControllerBase
    {
        private readonly ICorrectAnswerDao correctAns;

        public CorrectAnswerController(ICorrectAnswerDao correctAns)
        {
            this.correctAns = correctAns;
        }

        [HttpGet]
        public IActionResult GetCorrectAnswers()
        {
            var cAns = correctAns.FetchCorrectAnswers();
            return Ok(cAns);
        }
        [HttpPost]
        public IActionResult AddCAns(Correctanswer correctanswer)
        {
            var result = correctAns.AddCorrectAnswer(correctanswer);
            return this.CreatedAtAction("AddCorrectAnswer", $"{result} record added");
        }
        [HttpDelete]
        public IActionResult DeleteCorrectAns(int id)
        {
            var deleted = correctAns.DeleteCorrectAnswer(id);
            return Ok(deleted);        
        }
    }
}
