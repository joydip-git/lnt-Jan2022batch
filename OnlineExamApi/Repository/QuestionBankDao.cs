using OnlineExamSystemApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineExamSystemApp.Repository
{
    public class QuestionBankDao : IQuestionBankDao
    {
        //use the commented lines in case of DI 
        private readonly OnlineExamDbContext db;
        public QuestionBankDao(OnlineExamDbContext onlineexamDbContext)
        {
            this.db = onlineexamDbContext;
        }
        public List<Questionbank> FetchAll()
        {
            return db.Questionbank.ToList<Questionbank>();

        }
        public int AddOne(Questionbank questionbank)
        {
            db.Questionbank.Add(questionbank);
            return db.SaveChanges();
        }
        public Questionbank FetchOne(int id)
        {
            return db.Questionbank.Where(q => q.QId == id).First<Questionbank>();
        }
        public int DeleteOne(int id)
        {
            var founded = db.Questionbank.Where(q => q.QId == id).First<Questionbank>();
            db.Questionbank.Remove(founded);
            return db.SaveChanges();
        }
        public int UpdateOne(int id)
        {
            var updated = db.Questionbank.Where(q => q.QId == id).FirstOrDefault();
            if (updated != null)
            {
                updated.QId = id;
                updated.CategoryId = id;
                updated.LevelId = id;
                updated.QText = string.Empty;
            }
            return db.SaveChanges();
        }
    }
}
