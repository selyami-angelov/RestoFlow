using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoFlow.Core.Models.AwsS3
{
    public class S3ResponseDTO
    {
        public int StatusCode { get; set; } = 200;
        public string Message { get; set; } = "";
    }
}
