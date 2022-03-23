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
    public class UserExamRecordController : ControllerBase
    {
        private IUserExamRecordDao userExamRecord;
        public UserExamRecordController(IUserExamRecordDao userExamRecordDao)
        {
            Console.WriteLine("controller created...");
            this.userExamRecord = userExamRecordDao;
        }

        [HttpGet]
        public IActionResult GetRecords()
        {
            var records = userExamRecord.FetchAll();
            return this.Ok(records);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetRecordsById(string id)
        {
            var records = userExamRecord.FetchById(id);
            return this.Ok(records);
        }

        [HttpPost]
        public IActionResult AddRecord(Userexamrecord userexamrecord)
        {
            var added = userExamRecord.AddRecord(userexamrecord);
            return this.CreatedAtAction("AddRecord", $"{added} record added");
        }
    }
}
