using System.Security.Principal;
using SimpleServer.API.Interfaces;
namespace SimpleServer.API.Services
{
    public class CalculationService : ICalculationService
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
    }
}