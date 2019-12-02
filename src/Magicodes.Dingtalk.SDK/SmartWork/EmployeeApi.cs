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

        /// <summary>
        ///  获取员工花名册字段信息
        /// </summary>
        /// <param name="userIdList">员工userid列表，最大列表长度：20</param>
        /// <param name="findFilterList">需要获取的花名册字段列表，最大列表长度：20。具体业务字段的code参见附录（大小写敏感）。不传入该参数时，企业可获取所有字段信息。</param>
        /// <returns></returns>
        public async Task<GetHrmListInfoResult> GetHrmListInfo(string userIdList,string findFilterList) {
            return await Post<GetHrmListInfoResult>("topapi/smartwork/hrm/employee/list?access_token={ACCESS_TOKEN}", new
            {
                userid_list = userIdList,
                field_filter_list = findFilterList
            });
        }

        /// <summary>
        /// 查询企业待入职员工列表
        /// </summary>
        /// <param name="offset">分页游标，从0开始</param>
        /// <param name="size">分页大小，最大50</param>
        /// <returns></returns>
        public async Task<QueryPreentryResult> QueryPreentry(int offset,int size)
        {
            return await Post<QueryPreentryResult>("topapi/smartwork/hrm/employee/querypreentry?access_token={ACCESS_TOKEN}", new
            {
                offset = offset,
                size = size
            });
        }
    }
}
