using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static RestoFlow.Infrastructure.Constants.User;

namespace RestoFlow.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = FirstNameRequiredErrorMessage)]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength, ErrorMessage = FirstNameLengthErrorMessage)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = LastNameRequiredErrorMessage)]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength, ErrorMessage = LastNameLengthErrorMessage)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = RoleRequiredErrorMessage)]
        public int RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; } = null!;

    }
}
