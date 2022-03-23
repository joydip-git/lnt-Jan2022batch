using OnlineExamSystemApp.Models;
using System.Collections.Generic;

namespace OnlineExamSystemApp.Repository
{
    public class LoginDao:ILoginDao
    {
        private readonly OnlineExamDbContext onlineExamDbContext;

        public LoginDao(OnlineExamDbContext onlineExamDbContext)
        {
            this.onlineExamDbContext = onlineExamDbContext;
        }

        public List<ILoginDao> Fachall(string username, params string[] passsword)
        {
            throw new System.NotImplementedException();
        }
    }
}
