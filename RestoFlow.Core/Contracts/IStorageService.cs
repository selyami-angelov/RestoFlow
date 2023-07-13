using RestoFlow.Core.Models.AwsS3;

namespace RestoFlow.Core.Contracts
{
    public interface IStorageService
    {
        Task<S3ResponseDTO> UploadFileAsync(S3ObjectCreateDTO s3obj, AwsCredentials awsCredentials);
        Task<string> GeneratePresignedUrl(S3Object s3obj, AwsCredentials awsCredentials);

        Task<S3ResponseDTO> DeleteFileAsync(string objectKey, string bucketName, AwsCredentials awsCredentials);
    }
}
