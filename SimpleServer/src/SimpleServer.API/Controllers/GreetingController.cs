using Microsoft.AspNetCore.Mvc;
using SimpleServer.API.Interfaces;
using SimpleServer.API.Models.Requests;
using SimpleServer.API.Models.Responses;

namespace SimpleServer.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreetingController : ControllerBase 
    {
        private readonly IGreetingService _greetingService;

        public GreetingController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            var response = new ApiResponse<string>
            {
                Success = true,
                Message = "Приветствие успешно получено",
                Data = _greetingService.GetHello()
            };
            return Ok(response);
        }

        [HttpPost("greet")]
        public IActionResult Greet([FromBody] GreetRequest request)
        {
            var response = new ApiResponse<string>
            {
                Success = true,
                Message = "Приветствие успешно получено",
                Data = _greetingService.Greet(request.Name)
            };
            return Ok(response);
        }
    }
}