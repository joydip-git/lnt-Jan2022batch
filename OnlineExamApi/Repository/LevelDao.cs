using OnlineExamSystemApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineExamSystemApp.Repository
{
    public class LevelDao : ILevelDao
    {
        private readonly OnlineExamDbContext db;

        public LevelDao(OnlineExamDbContext db)
        {
            this.db = db;
        }

        public List<Difficultylevel> FetchLevel()
        {
            return db.Difficultylevel.ToList<Difficultylevel>();
        }

        public int AddLevel(Difficultylevel level)
        {
            db.Difficultylevel.Add(level);
            return db.SaveChanges();
        }
        public int DeleteLevel(int id)
        {
            var deleted = db.Difficultylevel.Where(d => d.LevelId == id).First<Difficultylevel>();
            db.Difficultylevel.Remove(deleted);
            return db.SaveChanges();
        }
    }
}
