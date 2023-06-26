using System.ComponentModel.DataAnnotations;

namespace RestoFlow.Core.Models.User
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
