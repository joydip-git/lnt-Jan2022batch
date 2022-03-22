namespace AuthService.Models
{
    public enum Roles
    {
        Admin,
        User
    }
    public class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
    }
}
