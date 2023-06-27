using AutoMapper;

using Microsoft.EntityFrameworkCore;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Reservation;
using RestoFlow.Infrastructure.Data.Models;


namespace RestoFlow.Core.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public ReservationService(IRepository _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }

        public async Task<List<ReservationDTO>> GetReservations()
        {
            var reservations = repository.All<Reservation>().Where(r => r.ReservationDate > DateTime.UtcNow);
            return mapper.Map<List<ReservationDTO>>(reservations);
        }

        public async Task<ReservationDTO> GetReservationById(int reservationId)
        {
            var reservation = await repository.GetByIdAsync<Reservation>(reservationId);

            if (reservation == null)
            {
                return null;
            }

            return mapper.Map<ReservationDTO>(reservation);
        }

        public async Task<ReservationDTO> CreateReservation(ReservationCreateDTO reservationCreateDto)
        {
            var reservation = mapper.Map<Reservation>(reservationCreateDto);
            var reservationTables = new List<ReservationTable>();

            foreach (var id in reservationCreateDto.ReservationTableIds)
            {
                var table = await repository.GetByIdAsync<Table>(id);

                if (table == null)
                {
                    return null;
                }

                var reservationTable = new ReservationTable()
                {
                    Reservation = reservation,
                    Table = table
                };
                reservationTables.Add(reservationTable);

            }


            reservation.ReservationTables = reservationTables;
            await repository.AddAsync(reservation);
            await repository.SaveChangesAsync();
            return mapper.Map<ReservationDTO>(reservation);
        }

        public async Task<ReservationDTO> UpdateReservation(int reservationId, ReservationEditDTO reservationUpdateDto)
        {
            var existingReservation = await repository.All<Reservation>().Include(r => r.ReservationTables).FirstOrDefaultAsync(r => r.ReservationId == reservationId);

            if (existingReservation == null)
            {
                return null;
            }

            existingReservation.ReservationTables.Clear();
            foreach (var id in reservationUpdateDto.ReservationTableIds)
            {
                var table = await repository.GetByIdAsync<Table>(id);

                if (table == null)
                {
                    return null;
                }

                var reservationTable = new ReservationTable()
                {
                    Reservation = existingReservation,
                    Table = table
                };
                existingReservation.ReservationTables.Add(reservationTable);

            }

            mapper.Map(reservationUpdateDto, existingReservation);
            repository.Update(existingReservation);
            await repository.SaveChangesAsync();
            return mapper.Map<ReservationDTO>(existingReservation);
        }

        public async Task<ReservationDTO> DeleteReservation(int reservationId)
        {
            var existingReservation = await repository.GetByIdAsync<Reservation>(reservationId);

            if (existingReservation == null)
            {
                return null;
            }

            existingReservation.IsCancelled = true;
            await repository.SaveChangesAsync();
            return mapper.Map<ReservationDTO>(existingReservation);
        }
    }
}
