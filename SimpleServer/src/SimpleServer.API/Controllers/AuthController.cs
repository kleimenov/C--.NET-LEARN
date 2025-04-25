using Microsoft.AspNetCore.Mvc;
using SimpleServer.API.Interfaces;
using SimpleServer.API.Models.Requests;
using SimpleServer.API.Models.Responses;

namespace SimpleServer.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase 
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            var response = new ApiResponse<string>
            {
                Success = true,
                Message = "Приветствие успешно получено",
                Data = _authService.GetHello()
            };
            return Ok(response);
        }

        [HttpPost("greet")]
        public IActionResult Greet([FromBody] AuthRequest request)
        {
            var response = new ApiResponse<string>
            {
                Success = true,
                Message = "Приветствие успешно получено",
                Data = _authService.Greet(request.Name)
            };
            return Ok(response);
        }
    }
}