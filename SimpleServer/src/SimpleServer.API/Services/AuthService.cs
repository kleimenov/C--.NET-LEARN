using SimpleServer.API.Interfaces;
namespace SimpleServer.API.Services
{
    public class AuthService : IAuthService
    {
        public string Greet(string name)
        {
            return $"Hello, {name}!";
        }

        public bool GetUser(string email)
        {
            // This is a placeholder implementation. In a real application, you would retrieve user data from a database, will be implemented later.
            var user = new Dictionary<string, object>
            {
                { "email", "Ivan3000@ivan.com" },
                { "name", "Ivan" },
                { "password", "666HellYeah" },
                { "active", true },
                { "deleted", false }
            };

            if (user == null || !user.ContainsKey("email") || user["email"] == null || user["email"].ToString() != email)
            {
                return false;
            }
            return true;
        }
    }
}