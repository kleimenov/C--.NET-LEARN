using Microsoft.AspNetCore.Mvc;
using SimpleServer.API.Interfaces;
using SimpleServer.API.Models.Requests;
using SimpleServer.API.Models.Responses;

namespace SimpleServer.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculateController : ControllerBase
    {
        private readonly ICalculationService _calculationService;

        public CalculateController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        [HttpGet("add")]
        public IActionResult Add([FromQuery] CalulateRequest request)
        {
            var result = _calculationService.Add(request.A, request.B);
            
            var response = new ApiResponse<int>
            {
                Success = true,
                Message = "Сумма успешно вычислена",
                Data = result
            };
            
            return Ok(response);
        }

        [HttpPost("subtract")]
        public IActionResult Subtract([FromBody] CalulateRequest request)
        {
            var result = _calculationService.Subtract(request.A, request.B);
            
            var response = new ApiResponse<int>
            {
                Success = true,
                Message = "Разность успешно вычислена",
                Data = result
            };
            
            return Ok(response);
        }
    }
}