using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemApp.BankingAPIService.DataAccessLayer
{
    public interface ILoginDao
    {
        string Authenticate(string uname, string pwd);
    }
}
