using System.ComponentModel.DataAnnotations;

using static RestoFlow.Infrastructure.Constants.Reservation;

namespace RestoFlow.Core.Models.Reservation
{
    public class ReservationCreateDTO
    {

        [Required(ErrorMessage = ReservationDateRequiredErrorMessage)]
        public DateTime ReservationDate { get; set; }

        [Range(PartySizeMinValue, PartySizeMaxValue, ErrorMessage = PartySizeErrorMessage)]
        public int PartySize { get; set; }

        public List<int> ReservationTableIds { get; set; } = null!;
    }
}
