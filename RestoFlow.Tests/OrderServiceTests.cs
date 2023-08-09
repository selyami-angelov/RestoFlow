using AutoMapper;

using MockQueryable.Moq;

using Moq;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Order;
using RestoFlow.Core.Services;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Tests
{
    [TestFixture]
    public class OrderServiceTests
    {
        private Mock<IRepository> mockRepository;
        private Mock<IMapper> mockMapper;
        private OrderService orderService;

        [SetUp]
        public void Setup()
        {
            mockRepository = new Mock<IRepository>();
            mockMapper = new Mock<IMapper>();
            orderService = new OrderService(mockRepository.Object, mockMapper.Object);
        }


        [Test]
        public async Task GetOrderById_ReturnsNull_WhenOrderIsDeleted()
        {
            // Arrange
            var orderId = 1;
            var dummyOrder = new Order { Id = orderId, isDeleted = true };

            var mockQueryable = new List<Order> { dummyOrder }.AsQueryable().BuildMock();
            mockRepository.Setup(repo => repo.GetByIdAsync<Order>(orderId)).ReturnsAsync(dummyOrder);

            // Act
            var result = await orderService.GetOrderById(orderId);

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetOrders_ReturnsListOfOrderDTOs()
        {
            // Arrange
            var dummyOrders = new List<Order>
        {
            new Order
            {
                Id = 1,
                CreatedBy = new ApplicationUser { FirstName = "John", LastName = "Doe" },
                Info = "Order 1 info",
                ProductQuantity = 2,
            },
            new Order
            {
                Id = 2,
                CreatedBy = new ApplicationUser { FirstName = "Jane", LastName = "Smith" },
                Info = "Order 2 info",
                ProductQuantity = 3,
            }
        };

            var mockQueryable = dummyOrders.AsQueryable().BuildMock();
            mockRepository.Setup(repo => repo.All<Order>()).Returns(mockQueryable);
            mockMapper.Setup(mapper => mapper.Map<OrderDTO>(It.IsAny<Order>()))
                      .Returns((Order source) => new OrderDTO
                      {
                          Id = source.Id,
                          CreatedBy = $"{source.CreatedBy.FirstName} {source.CreatedBy.LastName}",
                          Info = source.Info,
                          ProductQuantity = source.ProductQuantity,
                      });

            // Act
            var result = await orderService.GetOrders();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Exactly(dummyOrders.Count).Items);
        }

    }
}
