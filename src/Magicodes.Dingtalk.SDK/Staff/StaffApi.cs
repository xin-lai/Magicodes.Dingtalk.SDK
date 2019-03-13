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