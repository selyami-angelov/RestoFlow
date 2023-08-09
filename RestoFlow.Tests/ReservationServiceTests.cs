using AutoMapper;

using Moq;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Reservation;
using RestoFlow.Core.Services;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Tests
{

    [TestFixture]
    public class ReservationServiceTests
    {
        private Mock<IRepository> mockRepository;
        private Mock<IMapper> mockMapper;
        private ReservationService reservationService;

        [SetUp]
        public void Setup()
        {
            mockRepository = new Mock<IRepository>();
            mockMapper = new Mock<IMapper>();
            reservationService = new ReservationService(mockRepository.Object, mockMapper.Object);
        }

        [Test]
        public async Task GetReservationById_ReturnsNull_WhenReservationDoesNotExist()
        {
            // Arrange
            var reservationId = 1;
            mockRepository.Setup(repo => repo.GetByIdAsync<Reservation>(reservationId)).ReturnsAsync((Reservation)null);

            // Act
            var result = await reservationService.GetReservationById(reservationId);

            // Assert
            Assert.That(result, Is.Null);
        }


        [Test]
        public async Task DeleteReservation_ReturnsDeletedReservationDTO_WhenReservationExists()
        {
            // Arrange
            var reservationId = 1;
            var existingReservation = new Reservation { ReservationId = reservationId };
            var deletedReservation = new Reservation();
            var deletedReservationDto = new ReservationDTO();

            mockRepository.Setup(repo => repo.GetByIdAsync<Reservation>(reservationId)).ReturnsAsync(existingReservation);
            mockMapper.Setup(mapper => mapper.Map<ReservationDTO>(existingReservation)).Returns(deletedReservationDto);

            // Act
            var result = await reservationService.DeleteReservation(reservationId);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task DeleteReservation_ReturnsNull_WhenReservationDoesNotExist()
        {
            // Arrange
            var reservationId = 1;
            mockRepository.Setup(repo => repo.GetByIdAsync<Reservation>(reservationId)).ReturnsAsync((Reservation)null);

            // Act
            var result = await reservationService.DeleteReservation(reservationId);

            // Assert
            Assert.That(result, Is.Null);
        }

    }

}
