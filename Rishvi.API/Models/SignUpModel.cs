using System.ComponentModel.DataAnnotations;

namespace Rishvi.API.Models
{
    public class SignUpModel
    {
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public bool Terms { get; set; }
    }
}
