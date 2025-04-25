using SimpleServer.API.Interfaces;
namespace SimpleServer.API.Services
{
    public class GreetingService : IGreetingService
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