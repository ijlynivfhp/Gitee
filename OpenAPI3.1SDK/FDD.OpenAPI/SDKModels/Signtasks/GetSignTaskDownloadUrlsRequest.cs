using FDD.OpenAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDD.OpenAPI.SDKModels.Signtasks
{
    /// <summary>
    /// 获取签署文档下载链
    /// </summary>
    [RemoteService("/signtasks/getSignTaskDownloadUrls", "POST")]
    public class GetSignTaskDownloadUrlsRequest : BaseReqeust<GetSignTaskDownloadUrlsResponse>
    {
        public string taskId { get; set; }
        public List<File> files { get; set; }
        public class File {
            public string fileId { get; set; }
        }
    }
}
