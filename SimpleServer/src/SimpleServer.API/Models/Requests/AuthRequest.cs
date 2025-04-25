namespace SimpleServer.API.Models.Requests
{
    public class AuthRequest
    {
        public required string Name { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
    }
    public class AuthGetUserRequest
    {
        public required string Email { get; set; }
    }
}