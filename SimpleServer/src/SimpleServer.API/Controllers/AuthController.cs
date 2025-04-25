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

        [HttpGet("get_user")]
       public IActionResult GetUser([FromBody] AuthGetUserRequest request)
        {
            var result = _authService.GetUser(request.Email);
            if (!result)
            {
                var notFoundResponse = new ApiResponse<string>
                {
                    Success = false,
                    Message = "User not found",
                    Data = null
                };
                return NotFound(notFoundResponse);
            }
            var successResponse = new ApiResponse<string>
            {
                Success = true,
                Message = "User data successfully retrieved",
                Data = $"User with email {request.Email} found"
            };
            return Ok(successResponse);
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