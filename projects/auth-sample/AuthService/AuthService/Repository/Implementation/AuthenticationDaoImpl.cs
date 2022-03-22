using AuthService.Models;
using AuthService.Repository.Abstraction;
using AuthService.Repository.Data;
using System.Linq;

namespace AuthService.Repository.Implementation
{
    public class AuthenticationDaoImpl : IAuthentication
    {
        public bool AuthenticateUser(UserInfo userInfo)
        {
            var allUsers = UserRepository.Users;
            bool status = allUsers.Any(user => user.UserName == userInfo.UserName && user.Password == userInfo.Password);
            return status;
        }
    }
}
