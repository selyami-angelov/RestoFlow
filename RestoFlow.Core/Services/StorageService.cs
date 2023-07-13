using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.AwsS3;

using System.Net;

using S3Object = RestoFlow.Core.Models.AwsS3.S3Object;

namespace RestoFlow.Core.Services
{
    public class StorageService : IStorageService
    {
        public async Task<S3ResponseDTO> UploadFileAsync(S3ObjectCreateDTO s3obj, AwsCredentials awsCredentials)
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

                using var client = new AmazonS3Client(credentials, config);
                var transferUtility = new TransferUtility(client);

                await transferUtility.UploadAsync(uploadRequest);

                response.StatusCode = 200;
                response.Message = $"{s3obj.Name} has been uploaded successfully";
            }
            catch (AmazonS3Exception ex)
            {
                response.StatusCode = (int)ex.StatusCode;
                response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<S3ResponseDTO> DeleteFileAsync(string objectKey, string bucketName, AwsCredentials awsCredentials)
        {
            var credentials = new BasicAWSCredentials(awsCredentials.AwsKey, awsCredentials.AwsSecretKey);
            var config = new AmazonS3Config
            {
                RegionEndpoint = Amazon.RegionEndpoint.EUCentral1
            };

            var response = new S3ResponseDTO();

            try
            {
                var deleteRequest = new DeleteObjectRequest
                {
                    Key = objectKey,
                    BucketName = bucketName
                };

                using var client = new AmazonS3Client(credentials, config);
                var deleteResponse = await client.DeleteObjectAsync(deleteRequest);

                if (deleteResponse.HttpStatusCode == HttpStatusCode.NoContent)
                {
                    response.StatusCode = 200;
                    response.Message = $"{objectKey} has been deleted successfully";
                }
                else
                {
                    response.StatusCode = (int)deleteResponse.HttpStatusCode;
                    response.Message = $"Error occurred while deleting {objectKey}: {deleteResponse.HttpStatusCode}";
                }
            }
            catch (AmazonS3Exception ex)
            {
                response.StatusCode = (int)ex.StatusCode;
                response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<string> GeneratePresignedUrl(S3Object s3obj, AwsCredentials awsCredentials)
        {
            var credentials = new BasicAWSCredentials(awsCredentials.AwsKey, awsCredentials.AwsSecretKey);
            var config = new AmazonS3Config()
            {
                RegionEndpoint = Amazon.RegionEndpoint.EUCentral1
            };
            // Created s3 client
            using var client = new AmazonS3Client(credentials, config);

            var getPreSignedUrlRequest = new GetPreSignedUrlRequest
            {
                BucketName = s3obj.BucketName,
                Key = s3obj.Name,
                Expires = DateTime.UtcNow.AddHours(8),
                // Set any additional access restrictions or permissions as needed
            };

            var preSignedUrl =  client.GetPreSignedURL(getPreSignedUrlRequest);

            return preSignedUrl;
        }
    }
}
