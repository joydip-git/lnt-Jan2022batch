using OnlineExamSystemApp.Models;
using System.Collections.Generic;

namespace OnlineExamSystemApp.Repository
{
    public interface IQuestionBankDao
    {
        List<Questionbank> FetchAll();
        int AddOne(Questionbank question);
        Questionbank FetchOne(int id);
        int DeleteOne(int id);

        //int UpdateOne(int id);
        
    }
}