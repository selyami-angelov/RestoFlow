using RestoFlow.Core.Models.AwsS3;

namespace RestoFlow.Core.Contracts
{
    public interface IStorageService
    {
        Task<S3ResponseDTO> UploadFileAsync(S3Object s3obj, AwsCredentials awsCredentials);
    }
}
