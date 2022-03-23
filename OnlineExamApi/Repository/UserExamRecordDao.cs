using OnlineExamSystemApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineExamSystemApp.Repository
{
    public class UserExamRecordDao : IUserExamRecordDao
    {
        private readonly OnlineExamDbContext db;
        public UserExamRecordDao(OnlineExamDbContext onlineexamDbContext)
        {
            this.db = onlineexamDbContext;
        }
        public List<Userexamrecord> FetchAll()
        {
            return db.Userexamrecord.ToList<Userexamrecord>();
        }

        public List<Userexamrecord> FetchById(string id)
        {
            var records = db.Userexamrecord.Where(u => u.EmailId == id).ToList<Userexamrecord>();
            return records;
        }

        public int AddRecord(Userexamrecord examRecord)
        {
            db.Userexamrecord.Add(examRecord);
            return db.SaveChanges();
        }
    }   
}
