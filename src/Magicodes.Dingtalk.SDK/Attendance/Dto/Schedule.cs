// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : Schedule.cs
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

using Newtonsoft.Json;
using System;

namespace Magicodes.Dingtalk.SDK.Attendance.Dto
{
    /// <summary>
    ///     排班详情
    /// </summary>
    public class Schedule
    {
        /// <summary>
        ///     排班id
        /// </summary>
        [JsonProperty("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        ///     打卡类型，OnDuty表示上班打卡，OffDuty表示下班打卡
        /// </summary>
        [JsonProperty("check_type")]
        public string CheckType { get; set; }

        /// <summary>
        ///     审批id，结果集中没有的话表示没有审批单
        /// </summary>
        [JsonProperty("approve_id")]
        public long ApproveId { get; set; }

        /// <summary>
        ///     userId
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }

        /// <summary>
        ///     考勤班次Id
        /// </summary>
        [JsonProperty("class_id")]
        public long ClassId { get; set; }

        /// <summary>
        ///     班次配置id，结果集中没有的话表示使用全局班次配置
        /// </summary>
        [JsonProperty("class_setting_id")]
        public long ClassSettingId { get; set; }

        /// <summary>
        ///     打卡时间
        /// </summary>
        [JsonProperty("plan_check_time")]
        public DateTime? PlanCheckTime { get; set; }

        /// <summary>
        ///     考勤组id
        /// </summary>
        [JsonProperty("group_id")]
        public long GroupId { get; set; }
    }
}