namespace Rishvi.API.Models.Auth
{
    public class SignUpRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool Terms {  get; set; }
    }
}
