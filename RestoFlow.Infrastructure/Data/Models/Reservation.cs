using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static RestoFlow.Infrastructure.Constants.Reservation;

namespace RestoFlow.Infrastructure.Data.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required(ErrorMessage = UserRequiredErrorMessage)]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required(ErrorMessage = ReservationDateRequiredErrorMessage)]
        public DateTime ReservationDate { get; set; }

        [Range(PartySizeMinValue, PartySizeMaxValue, ErrorMessage = PartySizeErrorMessage)]
        public int PartySize { get; set; }

        public bool IsCancelled { get; set; } = false;

        public List<ReservationTable> ReservationTables { get; set; } = null!;
    }
}
