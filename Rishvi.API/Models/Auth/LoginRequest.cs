using System.ComponentModel.DataAnnotations;

namespace Rishvi.API.Models.Auth
{
    public class LoginRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
