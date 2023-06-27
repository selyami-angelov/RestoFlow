using RestoFlow.Core.Models.Reservation;

namespace RestoFlow.Core.Contracts
{
    public interface IReservationService
    {
        Task<List<ReservationDTO>> GetReservations();
        Task<ReservationDTO> GetReservationById(int reservationId);
        Task<ReservationDTO> CreateReservation(ReservationCreateDTO reservationCreateDto);
        Task<ReservationDTO> UpdateReservation(int reservationId, ReservationEditDTO reservationUpdateDto);
        Task<ReservationDTO> DeleteReservation(int reservationId);
    }

}
