using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Livora.Application.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            // Implement login logic
            return Ok(new { token = "jwt_token_here" });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            // Implement registration logic
            return Ok(new { message = "User registered successfully" });
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequest request)
        {
            // Implement token refresh logic
            return Ok(new { token = "new_jwt_token_here" });
        }
    }

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class RegisterRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }

    public class RefreshTokenRequest
    {
        public string RefreshToken { get; set; }
    }
}