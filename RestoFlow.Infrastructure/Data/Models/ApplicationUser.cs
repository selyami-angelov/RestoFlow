using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;

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

        public List<OccupiedTable> OccupiedTables { get; set; } = null!;
        public List<Bill> Bills { get; set; } = null!;

    }
}
