using System.ComponentModel.DataAnnotations;

using static RestoFlow.Infrastructure.Constants.User;

namespace RestoFlow.Core.Models.User
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = FirstNameRequiredErrorMessage)]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength, ErrorMessage = FirstNameLengthErrorMessage)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = LastNameRequiredErrorMessage)]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength, ErrorMessage = LastNameLengthErrorMessage)]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

    }
}
