namespace SimpleServer.API.Interfaces
{
    public interface IGreetingService
    {
        string Greet(string name);
        string GetHello();
    }
}