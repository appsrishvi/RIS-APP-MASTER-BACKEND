using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Rishvi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            // This is a dummy implementation for testing purposes
            // In a real scenario, we will implement the actual login logic here
            return Ok(new LoginResponse
            {
                Success = true,
                Message = "Login successful"
            });
        }
    }
    public class LoginRequest
    {
        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }
    public class LoginResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = String.Empty;
    }
}
