using FDD.OpenAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDD.OpenAPI.SDKModels.Accounts
{
    /// <summary>
    /// 员工数据同步接口
    /// </summary>
    [RemoteService("/org/employee/batchSyncEmployee", "POST")]
    public class BatchSyncEmployeeRequest : BaseReqeust<BatchSyncEmployeeResponse>
    {
        public string unionId { get; set; }
        public List<employeeInfo> employeeInfos { get; set; }
        public class employeeInfo
        {
            public string employeeName { get; set; }
            public string mobile { get; set; }
            public string email { get; set; }
            public int action { get; set; } = default;

        }
    }
}
