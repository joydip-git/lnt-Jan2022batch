using AuthService.Models;

namespace AuthService.Repository.Abstraction
{
    public interface IAuthentication
    {
        bool AuthenticateUser(UserInfo userInfo);
    }
}
