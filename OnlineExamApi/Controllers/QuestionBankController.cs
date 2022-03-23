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
    namespace OnlineExamSystemApp.Controllers
    {
        
        [Route("api/[controller]")]
        [ApiController]
        public class QuestionBankController : ControllerBase
        {
            private IQuestionBankDao questionBank;

            public QuestionBankController(IQuestionBankDao questionBank)
            {
                this.questionBank = questionBank;
            }

            [HttpGet]
            public IActionResult GetQuestion()
            {
                var fetchedData = questionBank.FetchAll();
                return this.Ok(fetchedData);
            }

            [HttpPost]
            public IActionResult AddQuestion(Questionbank question)
            {
                var result = questionBank.AddOne(question);
                return this.CreatedAtAction("AddQuestion", $"{result} record added");
            }

            [HttpGet]
            [Route("{id}")]
            public IActionResult GetQuestionById(int id)
            {
                var fetchedData = questionBank.FetchOne(id);
                return this.Ok(fetchedData);
            }
            [HttpDelete]
            public IActionResult DeleteQuestion(int id)
            {
                var deletedData = questionBank.DeleteOne(id);
                return this.Ok("deleted");
            }
        }
    }
}
