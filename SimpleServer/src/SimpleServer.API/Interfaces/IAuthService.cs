namespace SimpleServer.API.Interfaces
{
    public interface IAuthService
    {
        string Greet(string name);
        bool GetUser(string email);
    }
}