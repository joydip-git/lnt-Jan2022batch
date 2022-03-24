using Finance_Management.BusinessAccessLayer;
using System.Linq;
using Finance_Management.Repository;




namespace Finance_Management.DataAccessLayer
{
    public class UserTypeDao : IuserType
    {

        //private FinanceDbContext db;


        //public UserTypeDao(FinanceDbContext financeDbContext)
        //{
        //    db = financeDbContext;
        //}

        //public UserType GetById(int id)
        //{
        //    return db.UserType.Where(p => p.UserType_id == id).First<UserType>();

        //}
        public BusinessAccessLayer.UserType GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int update(BusinessAccessLayer.UserType id)
        {
            throw new System.NotImplementedException();
        }
    }
}


