using AuthService.Models;

namespace AuthService.Auth
{
    public interface IJwtTokenManager
    {
        string GenerateJwt(UserInfo user);
    }
}