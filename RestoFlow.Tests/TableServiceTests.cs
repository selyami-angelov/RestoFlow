using AutoMapper;

using MockQueryable.Moq;

using Moq;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Order;
using RestoFlow.Core.Models.Table;
using RestoFlow.Core.Models.User;
using RestoFlow.Core.Services;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Tests
{
    [TestFixture]
    public class TableServiceTests
    {
        private Mock<IRepository> repositoryMock;
        private Mock<IMapper> mapperMock;
        private TableService tableService;

        [SetUp]
        public void Setup()
        {
            var tables = new List<Table> { new Table { OccupiedTables = new List<OccupiedTable> { new OccupiedTable() } } };
            var tableQueryable = tables.AsQueryable().BuildMock();

            repositoryMock = new Mock<IRepository>();
            repositoryMock.Setup(repo => repo.All<Table>()).Returns(tableQueryable);

            mapperMock = new Mock<IMapper>();
            tableService = new TableService(repositoryMock.Object, mapperMock.Object);
        }

        [Test]
        public async Task GetTables_ReturnsListOfTableDTOs()
        {
            // Arrange
            var tables = new List<Table> { new Table(), new Table() };
            var tableDTOs = new List<TableDTO> { new TableDTO(), new TableDTO() };

            repositoryMock.Setup(repo => repo.All<Table>()).Returns(tables.AsQueryable());
            mapperMock.Setup(mapper => mapper.Map<List<TableDTO>>(tables)).Returns(tableDTOs);

            // Act
            var result = await tableService.GetTables();

            // Assert
            Assert.AreEqual(tableDTOs, result);
        }

        [Test]
        public async Task GetTableById_ExistingTableId_ReturnsTableDTO()
        {
            // Arrange
            var tableId = 1;
            var table = new Table();
            var tableDTO = new TableDTO();

            repositoryMock.Setup(repo => repo.GetByIdAsync<Table>(tableId)).ReturnsAsync(table);
            mapperMock.Setup(mapper => mapper.Map<TableDTO>(table)).Returns(tableDTO);

            // Act
            var result = await tableService.GetTableById(tableId);

            // Assert
            Assert.AreEqual(tableDTO, result);
        }


        [Test]
        public async Task AssignOrderToTable_ValidData_ReturnsTrue()
        {
            // Arrange
            var orderId = 1;
            var tableId = 1;
            var user = new ApplicationUser();
            var order = new Order();
            var table = new Table();

            repositoryMock.Setup(repo => repo.GetByIdAsync<Order>(orderId)).ReturnsAsync(order);
            repositoryMock.Setup(repo => repo.GetByIdAsync<Table>(tableId)).ReturnsAsync(table);
            repositoryMock.Setup(repo => repo.AddAsync<OccupiedTable>(It.IsAny<OccupiedTable>()))
                .Returns(Task.CompletedTask);
            repositoryMock.Setup(repo => repo.SaveChangesAsync()).ReturnsAsync(1); 

            // Act
            var result = await tableService.AssignOrderToTable(orderId, tableId, user);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task GetOccupiedTables_ReturnsListOfOccupiedTableDTOs()
        {
            // Arrange
            var occupiedTables = new List<OccupiedTableDTO> { new OccupiedTableDTO() };

            mapperMock.Setup(mapper => mapper.Map<TableDTO>(It.IsAny<Table>())).Returns(new TableDTO());
            mapperMock.Setup(mapper => mapper.Map<UserDTO>(It.IsAny<ApplicationUser>())).Returns(new UserDTO());
            mapperMock.Setup(mapper => mapper.Map<List<OrderDTO>>(It.IsAny<IEnumerable<Order>>()))
                .Returns(new List<OrderDTO>());

            // Act
            var result = await tableService.GetOccupiedTables();

            // Assert
            Assert.AreEqual(occupiedTables.Count, result.Count);
        }
    }
}
