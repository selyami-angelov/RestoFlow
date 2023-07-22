using Microsoft.Extensions.Configuration;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.AwsS3;

namespace RestoFlow.Core.Services
{
    public class AwsCredentialsService : IAwsCredentialsService
    {


        private readonly IConfiguration configuration;

        public AwsCredentialsService(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public AwsCredentials GetAwsCredentialsFromEnvironment()
        {
            var awsKey = Environment.GetEnvironmentVariable("AWS_ACCESS_KEY_ID");
            var awsSecretKey = Environment.GetEnvironmentVariable("AWS_SECRET_ACCESS_KEY");

            return new AwsCredentials
            {
                AwsKey = awsKey,
                AwsSecretKey = awsSecretKey
            };
        }

        public AwsCredentials GetAwsCredentialsFromAppSettings()
        {
            var awsKey = configuration["AWS_ACCESS_KEY_ID"];
            var awsSecretKey = configuration["AWS_SECRET_ACCESS_KEY"];

            return new AwsCredentials
            {
                AwsKey = awsKey,
                AwsSecretKey = awsSecretKey
            };
        }

    }
}
