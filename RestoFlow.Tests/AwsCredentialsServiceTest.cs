using Microsoft.Extensions.Configuration;

using Moq;

using RestoFlow.Core.Services;

namespace RestoFlow.Tests
{
    [TestFixture]
    public class AwsCredentialsServiceTests
    {
        private Mock<IConfiguration> mockConfiguration;
        private AwsCredentialsService awsCredentialsService;

        [SetUp]
        public void Setup()
        {
            mockConfiguration = new Mock<IConfiguration>();
            awsCredentialsService = new AwsCredentialsService(mockConfiguration.Object);
        }

        [Test]
        public void GetAwsCredentialsFromEnvironment_ReturnsCorrectCredentials()
        {
            // Arrange
            const string awsKey = "your-aws-key";
            const string awsSecretKey = "your-aws-secret-key";

            Environment.SetEnvironmentVariable("AWS_ACCESS_KEY_ID", awsKey);
            Environment.SetEnvironmentVariable("AWS_SECRET_ACCESS_KEY", awsSecretKey);

            // Act
            var result = awsCredentialsService.GetAwsCredentialsFromEnvironment();

            // Assert
            Assert.That(result.AwsKey, Is.EqualTo(awsKey));
            Assert.That(result.AwsSecretKey, Is.EqualTo(awsSecretKey));

            // Clean up
            Environment.SetEnvironmentVariable("AWS_ACCESS_KEY_ID", null);
            Environment.SetEnvironmentVariable("AWS_SECRET_ACCESS_KEY", null);
        }

        [Test]
        public void GetAwsCredentialsFromAppSettings_ReturnsCorrectCredentials()
        {
            // Arrange
            const string awsKey = "your-aws-key";
            const string awsSecretKey = "your-aws-secret-key";

            mockConfiguration.Setup(config => config["AWS_ACCESS_KEY_ID"]).Returns(awsKey);
            mockConfiguration.Setup(config => config["AWS_SECRET_ACCESS_KEY"]).Returns(awsSecretKey);

            // Act
            var result = awsCredentialsService.GetAwsCredentialsFromAppSettings();

            // Assert
            Assert.That(result.AwsKey, Is.EqualTo(awsKey));
            Assert.That(result.AwsSecretKey, Is.EqualTo(awsSecretKey));
        }

    }
}
