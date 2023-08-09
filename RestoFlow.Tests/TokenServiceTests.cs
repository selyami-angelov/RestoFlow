using Microsoft.AspNetCore.Identity;

using RestoFlow.Core.Services;

namespace RestoFlow.Tests
{
    [TestFixture]
    public class TokenServiceTests
    {
        private TokenService tokenService;

        [SetUp]
        public void Setup()
        {
            tokenService = new TokenService();
        }

        [Test]
        public void CreateToken_ValidUserAndRoles_ReturnsTokenString()
        {
            // Arrange
            var user = new IdentityUser
            {
                Id = "userId",
                UserName = "testuser",
                Email = "test@example.com"
            };
            var roles = new List<string> { "Role1", "Role2" };

            // Act
            var token = tokenService.CreateToken(user, roles);

            // Assert
            Assert.IsNotNull(token);
        }
    }
}
