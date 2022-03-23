using OnlineExamSystemApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineExamSystemApp.Repository
{
    public class CorrectAnswerDao : ICorrectAnswerDao
    {
        private readonly OnlineExamDbContext db;

        public CorrectAnswerDao(OnlineExamDbContext db)
        {
            this.db = db;
        }

        public List<Correctanswer> FetchCorrectAnswers()
        {
            return db.Correctanswer.ToList<Correctanswer>();
        }
        public int AddCorrectAnswer(Correctanswer answer)
        {
            db.Correctanswer.Add(answer);
            return db.SaveChanges();
        }
        public int DeleteCorrectAnswer(int id)
        {
            var deleted = db.Correctanswer.Where(c => c.CorrectAnsId == id).First<Correctanswer>();
            db.Correctanswer.Remove(deleted);
            return db.SaveChanges();
        }
    }
}
