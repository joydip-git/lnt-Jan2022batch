using OnlineExamSystemApp.Models;
using System.Collections.Generic;

namespace OnlineExamSystemApp.Repository
{
    public interface IAnswerBankDao
    {
        List<Answerbank> FetchAll();
        int AddOne(Answerbank answer);
        Answerbank FetchOne(int id);
        int DeleteOne(int id);
    }
}
