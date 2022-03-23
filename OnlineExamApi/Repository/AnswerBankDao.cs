using OnlineExamSystemApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineExamSystemApp.Repository
{
    public class AnswerBankDao : IAnswerBankDao
    {
        private readonly OnlineExamDbContext db;
        public AnswerBankDao(OnlineExamDbContext onlineexamDbContext)
        {
            this.db = onlineexamDbContext;
        }
        public List<Answerbank> FetchAll()
        {

            return db.Answerbank.ToList<Answerbank>();

        }
        public int AddOne(Answerbank answerbank)
        {
            db.Answerbank.Add(answerbank);
            return db.SaveChanges();
        }
        public Answerbank FetchOne(int id)
        {
            return db.Answerbank.Where(a => a.AnsId == id).First<Answerbank>();
        }
        public int DeleteOne(int id)
        {
            var founded = db.Answerbank.Where(a => a.AnsId == id).First<Answerbank>();
            db.Answerbank.Remove(founded);
            return db.SaveChanges();
        }
    }
}
