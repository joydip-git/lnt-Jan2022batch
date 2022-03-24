using Finance_Management.BusinessAccessLayer;
using Finance_Management.Repository;

namespace Finance_Management.DataAccessLayer
{
    public interface ILoginType
    {
         public int Update(Logintype password);
        object UpdatePassword(LoginType password);
    }
}
