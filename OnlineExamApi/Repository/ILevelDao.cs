using OnlineExamSystemApp.Models;
using System.Collections.Generic;

namespace OnlineExamSystemApp.Repository
{
    public interface ILevelDao
    {
        List<Difficultylevel> FetchLevel();
        int AddLevel(Difficultylevel level);
        int DeleteLevel(int id);
    }
}
