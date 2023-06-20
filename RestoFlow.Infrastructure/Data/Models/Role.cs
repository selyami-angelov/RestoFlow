using System.ComponentModel.DataAnnotations;

using static RestoFlow.Infrastructure.Constants.Role;

namespace RestoFlow.Infrastructure.Data.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = RoleNameRequiredErrorMessage)]
        [StringLength(RoleNameMaxLength, MinimumLength = RoleNameMinLength, ErrorMessage = RoleNameLengthErrorMessage)]
        public string Name { get; set; } = null!;

    }
}
