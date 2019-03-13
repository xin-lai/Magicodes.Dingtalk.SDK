// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : DailyApi.cs
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
using Magicodes.Dingtalk.SDK.Daily.Dto;
using Magicodes.Dingtalk.SDK.Helper;
using Microsoft.Extensions.Logging;

namespace Magicodes.Dingtalk.SDK.Daily
{
    public class DailyApi : ApiBase
    {
        public DailyApi(ILogger<DailyApi> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }


        /// <summary>
        ///     获取用户日志数据(日报)
        /// </summary>
        /// <returns></returns>
        public async Task<DailyApiResult> DailyList(DateTime? startTime = null, DateTime? endTime = null,
            string templateName = "日报", string userId = null, int cursor = 0, int size = 10)
        {
            if (!startTime.HasValue)
                startTime = Convert.ToDateTime(TimeZoneHelper.GetChinaDateTime().AddDays(-1)
                    .ToString("yyyy-MM-dd 13:00:00"));
            if (!endTime.HasValue)
                endTime = Convert.ToDateTime(TimeZoneHelper.GetChinaDateTime().ToString("yyyy-MM-dd 10:00:00"));

            return await Post<DailyApiResult>(
                "topapi/report/list?access_token={access_token}", new
                {
                    start_time = startTime.Value.ConvertToTimeStamp(),
                    end_time = endTime.Value.ConvertToTimeStamp(),
                    template_name = templateName,
                    userid = userId,
                    cursor,
                    size
                });
        }
    }
}