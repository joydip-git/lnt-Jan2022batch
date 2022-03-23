using OnlineExamSystemApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineExamSystemApp.Repository
{
    public class RegistrationDao : IRegistrationDao
    {
        private readonly OnlineExamDbContext db;
        public RegistrationDao(OnlineExamDbContext onlineexamDbContext)
        {
            this.db = onlineexamDbContext;
            System.Console.WriteLine("dao created");
        }
        public List<Registration> FetchAll()
        {
            return this.db.Registration.ToList<Registration>();
        }
        public int AddOne(Registration registration)
        {
            db.Registration.Add(registration);
            return db.SaveChanges();
        }
        public Registration FetchOne(int id)
        {
            return db.Registration.Where(r => r.RegId == id).First<Registration>();
        }
    }
}
