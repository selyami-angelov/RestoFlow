namespace RestoFlow.Core.Models.AwsS3
{
    public class S3ObjectCreateDTO : S3Object
    {
        public MemoryStream InputStream { get; set; } = null!;

    }
}
