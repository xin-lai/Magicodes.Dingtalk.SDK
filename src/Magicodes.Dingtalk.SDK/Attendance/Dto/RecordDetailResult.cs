// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : RecordDetailResult.cs
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

using Magicodes.Dingtalk.SDK.Attendance.Dto.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Magicodes.Dingtalk.SDK.Attendance.Dto
{
    /// <summary>
    ///     打卡详细的结果
    /// </summary>
    public class RecordDetailResult
    {
        /// <summary>
        ///     修改时间
        /// </summary>
        [JsonProperty("gmtModified")]
        public long GMTModified { get; set; }

        /// <summary>
        ///     是否合法
        /// </summary>
        [JsonProperty("isLegal")]
        public string IsLegal { get; set; }

        /// <summary>
        ///     计算迟到和早退，基准时间
        /// </summary>
        [JsonProperty("baseCheckTime")]
        public long BaseCheckTime { get; set; }

        /// <summary>
        ///     唯一标示ID
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        ///     用户打卡地址
        /// </summary>
        [JsonProperty("userAddress")]
        public string UserAddress { get; set; }

        /// <summary>
        ///     企业内的员工id列表，最多不能超过50个
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        ///     考勤类型（OnDuty：上班，OffDuty：下班）
        /// </summary>
        [JsonProperty("checkType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CheckTypeEnum CheckType { get; set; }

        /// <summary>
        ///     时间结果（Normal:正常;Early:早退; Late:迟到;SeriousLate:严重迟到；Absenteeism:旷工迟到；NotSigned:未打卡）
        /// </summary>
        [JsonProperty("timeResult")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeResultEnum TimeResult { get; set; }

        /// <summary>
        ///     设备Id
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        ///     企业Id
        /// </summary>
        [JsonProperty("corpId")]
        public string CorpId { get; set; }

        /// <summary>
        ///     数据来源（ATM:考勤机;BEACON:IBeacon;DING_ATM:钉钉考勤机;USER:用户打卡;BOSS:老板改签;APPROVE:审批系统;SYSTEM:考勤系统;AUTO_CHECK:自动打卡）
        /// </summary>
        [JsonProperty("sourceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SourceTypeEnum SourceType { get; set; }

        /// <summary>
        ///     工作日
        /// </summary>
        [JsonProperty("workDate")]
        public long WorkDate { get; set; }

        /// <summary>
        ///     排班打卡时间
        /// </summary>
        [JsonProperty("planCheckTime")]
        public long PlanCheckTime { get; set; }

        /// <summary>
        ///     创建时间
        /// </summary>
        [JsonProperty("gmtCreate")]
        public long GMTCreate { get; set; }

        /// <summary>
        ///     定位方法
        /// </summary>
        [JsonProperty("locationMethod")]
        public string LocationMethod { get; set; }

        /// <summary>
        ///     位置结果（Normal:范围内；Outside:范围外；NotSigned：未打卡）
        /// </summary>
        [JsonProperty("locationResult")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DetailLocationResultEnum LocationResult { get; set; }

        /// <summary>
        ///     用户打卡经度
        /// </summary>
        [JsonProperty("userLongitude")]
        public float UserLongitude { get; set; }

        /// <summary>
        ///     排班ID
        /// </summary>
        [JsonProperty("planId")]
        public long PlanId { get; set; }

        /// <summary>
        ///     考勤组ID
        /// </summary>
        [JsonProperty("groupId")]
        public long GroupId { get; set; }

        /// <summary>
        ///     用户打卡定位精度
        /// </summary>
        [JsonProperty("userAccuracy")]
        public long UserAccuracy { get; set; }

        /// <summary>
        ///     实际打卡时间
        /// </summary>
        [JsonProperty("userCheckTime")]
        public long UserCheckTime { get; set; }

        /// <summary>
        ///     用户打卡纬度
        /// </summary>
        [JsonProperty("userLatitude")]
        public float UserLatitude { get; set; }

        /// <summary>
        ///     关联的审批实例id，可以审批数据获取接口配合使用
        /// </summary>
        [JsonProperty("procInstId")]
        public string ProcInstId { get; set; }

        /// <summary>
        ///     关联的审批id，当该字段非空时，表示打卡记录与请假、加班等审批有关
        /// </summary>
        [JsonProperty("approveId")]
        public string ApproveId { get; set; }
    }
}