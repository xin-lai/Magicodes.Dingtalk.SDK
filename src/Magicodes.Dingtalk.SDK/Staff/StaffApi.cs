// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : StaffApi.cs
//           description :
//   
//           created by 雪雁 at  2019-03-13 10:03
//           Mail: wenqiang.li@xin-lai.com
//           QQ群：85318032（技术交流）
//           Blog：http://www.cnblogs.com/codelove/
//           GitHub：https://github.com/xin-lai
//           Home：http://xin-lai.com
//   
// ======================================================================

using System;
using System.Threading.Tasks;
using Magicodes.Dingtalk.SDK.Staff.Dto;
using Microsoft.Extensions.Logging;

namespace Magicodes.Dingtalk.SDK.Staff
{
    public class StaffApi : ApiBase
    {
        public StaffApi(ILogger<StaffApi> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        /// <summary>
        ///     查询企业在职员工列表(所以员工userId)
        /// </summary>
        /// <param name="statusList">在职员工子状态筛选，其他状态无效。2，试用期；3，正式；5，待离职；-1，无状态</param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public async Task<StaffInfoResult> StaffInfos(string statusList, int offset = 0, int size = 20)
        {
            return await Post<StaffInfoResult>(
                "topapi/smartwork/hrm/employee/queryonjob?access_token={ACCESS_TOKEN}", new
                {
                    status_list = statusList,
                    offset,
                    size
                });
        }


        /// <summary>
        ///     获取员工信息(单个)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="lang">暂只支持zh_CN</param>
        /// <returns></returns>
        public async Task<StaffResult> Get(string userId, string lang = "zh_CN")
        {
            return await Get<StaffResult>(
                $"user/get?access_token={{access_token}}&userid={userId}");
        }
    }
}