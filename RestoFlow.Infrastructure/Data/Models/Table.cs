using System.ComponentModel.DataAnnotations;

using static RestoFlow.Infrastructure.Constants.Table;

namespace RestoFlow.Infrastructure.Data.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = TableNameRequiredErrorMessage)]
        [StringLength(TableNameMaxLength, MinimumLength = TableNameMinLength,
            ErrorMessage = TableNameLengthErrorMessage)]
        public string TableName { get; set; } = null!;
    }
}
