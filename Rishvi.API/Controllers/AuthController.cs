using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rishvi.API.Models.Auth;

namespace Rishvi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            // This is a dummy implementation for testing purposes
            // In a real scenario, we will implement the actual login logic here
            if(request.Username == request.Password)
            {
                return Ok(new LoginResponse
                {
                    Success = true,
                    Message = "Login successful"
                });
            }
            else
            {
                return BadRequest();
            }
        }

		[HttpPost("signup")]
		public async Task<IActionResult> SignUp(SignUpRequest request)
		{
			// This is a dummy implementation for testing purposes
			// In a real scenario, we will implement the actual login logic here
			if (request.Username == request.Password)
			{
				return Ok(new LoginResponse
				{
					Success = true,
					Message = "Login successful"
				});
			}
			else
			{
				return BadRequest();
			}
		}

		//[HttpPost("signup")]
		//public async Task<IActionResult> SignUp(SignUpRequest request)
		//{
		//    // This is a dummy implementation for testing purposes
		//    // In a real scenario, we will implement the actual login logic here
		//    if (request.Username == request.Password)
		//    {
		//        return Ok(new SignUpResponse
		//        {
		//            Success = true,
		//            Message = "SignUp successful"
		//        });
		//    }
		//    else
		//    {
		//        return BadRequest();
		//    }
		//}
		[HttpPost("resetpassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest request)
        {
            // This is a dummy implementation for testing purposes
            // In a real scenario, we will implement the actual login logic here
            if (request.Username == "pratham@rishvi.co.uk")
            {
                return Ok(new ResetPasswordResponse
                {
                    Success = true,
                    Message = "Reset Password successful"
                });
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
