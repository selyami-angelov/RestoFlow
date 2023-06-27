using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Core.Models.Reservation
{
    public class ReservationDTO
    {
        public int ReservationId { get; set; }

        public string UserId { get; set; } = null!;

        public DateTime ReservationDate { get; set; }

        public int PartySize { get; set; }

        public bool IsCancelled { get; set; } = false;

    }
}
