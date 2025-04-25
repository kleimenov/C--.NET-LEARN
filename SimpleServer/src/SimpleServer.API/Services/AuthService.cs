using SimpleServer.API.Interfaces;
namespace SimpleServer.API.Services
{
    public class AuthService : IAuthService
    {
        public string Greet(string name)
        {
            return $"Hello, {name}!";
        }

        public string GetHello()
        {
            return "Hello, World!";
        }
    }
}