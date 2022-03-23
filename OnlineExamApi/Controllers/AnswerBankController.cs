using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineExamSystemApp.Models;
using OnlineExamSystemApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineexamsystemapp.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Answerbankcontroller : ControllerBase
    {
        private IAnswerBankDao answerbank;

        public Answerbankcontroller(IAnswerBankDao answerbank)
        {
            this.answerbank = answerbank;
        }

        [HttpGet]
        public IActionResult GetAnswer()
        {
            var fetcheddata = answerbank.FetchAll();
            return null;
        }

        [HttpPost]
        public IActionResult GetanswerById(int id)
        {
            var fetcheddata = answerbank.FetchOne(id);
            return this.Ok(fetcheddata);
        }

    }
}
