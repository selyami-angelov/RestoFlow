using System.ComponentModel.DataAnnotations;

namespace RestoFlow.Core.Models.Reservation
{
    public class ReservationEditDTO : ReservationCreateDTO
    {

        [Required]
        public bool IsCancelled { get; set; } = false!;

    }
}
