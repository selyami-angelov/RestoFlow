using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Transfer;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.AwsS3;

namespace RestoFlow.Core.Services
{
    public class StorageService : IStorageService
    {
        public async Task<S3ResponseDTO> UploadFileAsync(S3Object s3obj, AwsCredentials awsCredentials)
        {
            var credentials = new BasicAWSCredentials(awsCredentials.AwsKey, awsCredentials.AwsSecretKey);
            var config = new AmazonS3Config()
            {
                RegionEndpoint = Amazon.RegionEndpoint.EUCentral1
            };

            var response = new S3ResponseDTO();

            try
            {
                var uploadRequest = new TransferUtilityUploadRequest()
                {
                    InputStream = s3obj.InputStream,
                    Key = s3obj.Name,
                    BucketName = s3obj.BucketName,
                    CannedACL = S3CannedACL.NoACL
                };

                // Created s3 client
                using var client = new AmazonS3Client(credentials, config);

                // Upload utility
                var transferUtility = new TransferUtility(client);

                // Uploading...
                await transferUtility.UploadAsync(uploadRequest);

                response.StatusCode = 200;
                response.Mesage = $"{s3obj.Name} has been uploaded successfully";
            }
            catch (AmazonS3Exception ex)
            {
                response.StatusCode = (int)ex.StatusCode;
                response.Mesage = ex.Message;
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Mesage = ex.Message;
            }

            return response;
        }
    }
}
