using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDD.OpenAPI.SDKModels.Signtasks
{
    public class GetSignTaskDownloadUrlsResponse
    {
        public string downloadZipUrl { get; set; }
        public List<DownloadUrl> downloadUrls { get; set; }
        public class DownloadUrl {
            public string fileName { get; set; }
            public string fileId { get; set; }
            public string downloadUrl { get; set; }
            public int fileType { get; set; } = 1;
        }
    }
}
