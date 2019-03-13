using System;
using System.Threading.Tasks;
using Magicodes.Dingtalk.SDK.SmartWork.Dto;
using Magicodes.Dingtalk.SDK.Staff.Dto;
using Microsoft.Extensions.Logging;

namespace Magicodes.Dingtalk.SDK.SmartWork
{
    /// <summary>
    /// 员工
    /// </summary>
    public class EmployeeApi: ApiBase
    {
        public EmployeeApi(ILogger<EmployeeApi> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {

        }
        /// <summary>
        ///     查询企业在职员工列表
        /// </summary>
        /// <param name="statusList">在职员工子状态筛选，其他状态无效。2，试用期；3，正式；5，待离职；-1，无状态</param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public async Task<QueryOnJobResult> QueryOnJob(string statusList = "2,3,5,-1", int offset = 0, int size = 20)
        {
            return await Post<QueryOnJobResult>(
                "topapi/smartwork/hrm/employee/queryonjob?access_token={ACCESS_TOKEN}", new
                {
                    status_list = statusList,
                    offset,
                    size
                });
        }
    }
}
