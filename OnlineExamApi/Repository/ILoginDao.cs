using System.Collections.Generic;

namespace OnlineExamSystemApp.Repository
{
    public interface ILoginDao
    {
        List<ILoginDao> Fachall(string username, params string[] passsword);
    }
}
