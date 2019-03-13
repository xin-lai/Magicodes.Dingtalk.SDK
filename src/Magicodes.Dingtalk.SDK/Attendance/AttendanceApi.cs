// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : AttendanceApi.cs
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
using System.Collections.Generic;
using System.Threading.Tasks;
using Magicodes.Dingtalk.SDK.Attendance.Dto;
using Magicodes.Dingtalk.SDK.Helper;
using Microsoft.Extensions.Logging;

namespace Magicodes.Dingtalk.SDK.Attendance
{
    /// <summary>
    ///     考勤相关
    /// </summary>
    public class AttendanceApi : ApiBase
    {
        public AttendanceApi(ILogger<AttendanceApi> logger, IServiceProvider serviceProvider) : base(logger,
            serviceProvider)
        {
        }

        public async Task<ListScheduleResult> ListSchedule(DateTime? workDate = null, int offset = 0, int size = 200)
        {
            if (!workDate.HasValue) workDate = TimeZoneHelper.GetChinaDateTime();
            return await Post<ListScheduleResult>(
                "topapi/attendance/listschedule?access_token={ACCESS_TOKEN}", new
                {
                    workDate = workDate.Value.ToString("yyyy-MM-dd"),
                    offset,
                    size
                });
        }

        /// <summary>
        ///     获取打卡详情
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="checkDateFrom">查询考勤打卡记录的起始工作日。</param>
        /// <param name="checkDateTo">查询考勤打卡记录的结束工作日。注意，起始与结束工作日最多相隔7天</param>
        /// <param name="isI18n">是否为海外企业使用</param>
        /// <returns></returns>
        public async Task<ListRecordResult> ListRecord(List<string> userIds, DateTime checkDateFrom,
            DateTime checkDateTo, bool isI18n = false)
        {
            return await Post<ListRecordResult>(
                "attendance/listRecord?access_token={ACCESS_TOKEN}", new
                {
                    userIds,
                    checkDateFrom = checkDateFrom.ToString("yyyy-MM-dd HH:mm:ss"),
                    checkDateTo = checkDateTo.ToString("yyyy-MM-dd HH:mm:ss"),
                    isI18n
                });
        }


        /// <summary>
        ///     获取打卡结果
        ///     该接口用于返回企业内员工的实际打卡结果。比如，企业给一个员工设定的排班是上午9点和下午6点各打一次卡，即使员工在这期间打了多次，该接口也只会返回两条记录，包括上午的打卡结果和下午的打卡结果。
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="workDateFrom"></param>
        /// <param name="workDateTo"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="isI18n"></param>
        /// <returns></returns>
        public async Task<AttendanceListResult> List(List<string> userIds, DateTime workDateFrom, DateTime workDateTo,
            int offset = 0, int limit = 50, bool isI18n = false)
        {
            return await Post<AttendanceListResult>(
                "attendance/list?access_token={ACCESS_TOKEN}", new
                {
                    userIdList = userIds,
                    workDateFrom = workDateFrom.ToString("yyyy-MM-dd HH:mm:ss"),
                    workDateTo = workDateTo.ToString("yyyy-MM-dd HH:mm:ss"),
                    offset,
                    limit,
                    isI18n
                });
        }
    }
}