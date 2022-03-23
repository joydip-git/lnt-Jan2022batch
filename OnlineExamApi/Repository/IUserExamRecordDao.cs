using OnlineExamSystemApp.Models;
using System.Collections.Generic;

namespace OnlineExamSystemApp.Repository
{
    public interface IUserExamRecordDao
    {
        List<Userexamrecord> FetchAll();
        List<Userexamrecord> FetchById(string emailId);
        int AddRecord(Userexamrecord userexamrecord);
    }
}