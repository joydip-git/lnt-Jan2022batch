using OnlineExamSystemApp.Models;
using System.Collections.Generic;

namespace OnlineExamSystemApp.Repository
{
    public interface IRegistrationDao
    {
            List<Registration> FetchAll();
            int AddOne(Registration registration);
            Registration FetchOne(int id);
    }
}