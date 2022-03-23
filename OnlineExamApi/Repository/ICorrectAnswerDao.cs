using OnlineExamSystemApp.Models;
using System.Collections.Generic;

namespace OnlineExamSystemApp.Repository
{
    public interface ICorrectAnswerDao
    {
        List<Correctanswer> FetchCorrectAnswers();
        int AddCorrectAnswer(Correctanswer answer);
        int DeleteCorrectAnswer(int id);
    }
}
