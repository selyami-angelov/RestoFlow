using RestoFlow.Core.Models.AwsS3;

namespace RestoFlow.Core.Contracts
{
    public interface IAwsCredentialsService
    {
        AwsCredentials GetAwsCredentialsFromEnvironment();
        AwsCredentials GetAwsCredentialsFromAppSettings();
    }
}
