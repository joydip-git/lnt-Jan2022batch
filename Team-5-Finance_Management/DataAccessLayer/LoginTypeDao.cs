using Finance_Management.Repository;
using Finance_Management.DataAccessLayer.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using Finance_Management.BusinessAccessLayer;
using Finance_Management.DataAccessLayer.DataAccessLayer;

namespace Finance_Management.DataAccessLayer
{
    public class LoginTypeDao : ILoginType
    {

        private FinancedbContext db;
        public LoginTypeDao(FinancedbContext financeDbContext)
        {
            db = financeDbContext;
        }


        public int Update(Logintype password)
        {
            db.Logintype.Update(password);
            return db.SaveChanges();
        }

        public object UpdatePassword(LoginType password)
        {
            throw new NotImplementedException();
        }
    }


}
