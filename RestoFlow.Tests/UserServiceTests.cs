using AutoMapper;

using Microsoft.AspNetCore.Identity;

using MockQueryable.Moq;

using Moq;

using RestoFlow.Core.Models.User;
using RestoFlow.Core.Services;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        private Mock<UserManager<ApplicationUser>> userManagerMock;
        private Mock<IMapper> mapperMock;
        private UserService userService;

        [SetUp]
        public void Setup()
        {
            var users = new List<ApplicationUser> { new ApplicationUser(), new ApplicationUser() };
            var userQueryable = users.AsQueryable().BuildMock();

            userManagerMock = new Mock<UserManager<ApplicationUser>>(
                Mock.Of<IUserStore<ApplicationUser>>(), null, null, null, null, null, null, null, null
            );

            userManagerMock.Setup(manager => manager.Users).Returns(userQueryable);

            mapperMock = new Mock<IMapper>();
            userService = new UserService(userManagerMock.Object, mapperMock.Object);
        }

        [Test]
        public async Task GetAllUsersAsync_ReturnsListOfUserDTOs()
        {
            // Arrange
            userManagerMock.Setup(manager => manager.GetRolesAsync(It.IsAny<ApplicationUser>()))
                .ReturnsAsync(new List<string>());

            mapperMock.Setup(mapper => mapper.Map<UserDTO>(It.IsAny<ApplicationUser>()))
                .Returns(new UserDTO());

            // Act
            var result = await userService.GetAllUsersAsync();

            // Assert
            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public async Task AssignRoleAsync_ValidUserIdAndRole_ReturnsTrue()
        {
            // Arrange
            var userId = "userId";
            var role = "Role1";
            var user = new ApplicationUser();

            userManagerMock.Setup(manager => manager.FindByIdAsync(userId))
                .ReturnsAsync(user);
            userManagerMock.Setup(manager => manager.AddToRoleAsync(user, role))
                .ReturnsAsync(IdentityResult.Success);

            // Act
            var result = await userService.AssignRoleAsync(userId, role);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task RemoveRoleAsync_ValidUserIdAndRole_ReturnsTrue()
        {
            // Arrange
            var userId = "userId";
            var role = "Role1";
            var user = new ApplicationUser();

            userManagerMock.Setup(manager => manager.FindByIdAsync(userId))
                .ReturnsAsync(user);
            userManagerMock.Setup(manager => manager.RemoveFromRoleAsync(user, role))
                .ReturnsAsync(IdentityResult.Success);

            // Act
            var result = await userService.RemoveRoleAsync(userId, role);

            // Assert
            Assert.That(result, Is.True);
        }

    }

}
