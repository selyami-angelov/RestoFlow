using Amazon.Auth.AccessControlPolicy;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Reservation;

namespace RestoFlow.Api.Controllers
{
    [ApiController]
    [Route("api/reservations")]
    [Authorize(Policy = "AdminOrWaiterPolicy")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ReservationController(IReservationService _reservationService)
        {
            reservationService = _reservationService;
        }

        /// <summary>
        /// Get all reservations.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetReservations()
        {
            var reservations = await reservationService.GetReservations();
            return Ok(reservations);
        }

        /// <summary>
        /// Get a reservation by ID.
        /// </summary>
        /// <param name="reservationId">The ID of the reservation.</param>
        [HttpGet("{reservationId}")]
        public async Task<IActionResult> GetReservationById(int reservationId)
        {
            var reservation = await reservationService.GetReservationById(reservationId);
            if (reservation == null)
            {
                return NotFound();
            }

            return Ok(reservation);
        }

        /// <summary>
        /// Create a new reservation.
        /// </summary>
        /// <param name="reservationCreateDto">The reservation details.</param>
        [HttpPost]
        public async Task<IActionResult> CreateReservation([FromBody] ReservationCreateDTO reservationCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdReservation = await reservationService.CreateReservation(reservationCreateDto);
            return CreatedAtAction(nameof(GetReservationById), new { reservationId = createdReservation.ReservationId }, createdReservation);
        }

        /// <summary>
        /// Update a reservation by ID.
        /// </summary>
        /// <param name="reservationId">The ID of the reservation.</param>
        /// <param name="reservationUpdateDto">The updated reservation details.</param>
        [HttpPut("{reservationId}")]
        public async Task<IActionResult> UpdateReservation(int reservationId, [FromBody] ReservationEditDTO reservationUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedReservation = await reservationService.UpdateReservation(reservationId, reservationUpdateDto);
            if (updatedReservation == null)
            {
                return NotFound();
            }

            return Ok(updatedReservation);
        }

        /// <summary>
        /// Cancel a reservation by ID.
        /// </summary>
        /// <param name="reservationId">The ID of the reservation.</param>
        [HttpDelete("{reservationId}")]
        public async Task<IActionResult> DeleteReservation(int reservationId)
        {
            var deletedReservation = await reservationService.DeleteReservation(reservationId);
            if (deletedReservation == null)
            {
                return NotFound();
            }

            return Ok(deletedReservation);
        }
    }

}
