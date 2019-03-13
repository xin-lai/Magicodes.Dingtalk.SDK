// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : SourceTypeEnum.cs
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

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Magicodes.Dingtalk.SDK.Attendance.Dto.Enum
{
    /// <summary>
    ///     数据来源
    /// </summary>
    public enum SourceTypeEnum
    {
        /// <summary>
        ///     考勤机
        /// </summary>
        [Display(Name = "考勤机")] [EnumMember(Value = "ATM")]
        ATM = 0,

        /// <summary>
        ///     IBeacon
        /// </summary>
        [Display(Name = "IBeacon")] [EnumMember(Value = "BEACON")]
        Beacon = 1,

        /// <summary>
        ///     钉钉考勤机
        /// </summary>
        [Display(Name = "钉钉考勤机")] [EnumMember(Value = "DING_ATM")]
        DingATM = 2,

        /// <summary>
        ///     用户打卡
        /// </summary>
        [Display(Name = "用户打卡")] [EnumMember(Value = "USER")]
        User = 3,

        /// <summary>
        ///     老板改签
        /// </summary>
        [Display(Name = "老板改签")] [EnumMember(Value = "BOSS")]
        Boos = 4,

        /// <summary>
        ///     审批系统
        /// </summary>
        [Display(Name = "审批系统")] [EnumMember(Value = "APPROVE")]
        Approve = 5,

        /// <summary>
        ///     考勤系统
        /// </summary>
        [Display(Name = "考勤系统")] [EnumMember(Value = "SYSTEM")]
        System = 6,

        /// <summary>
        ///     自动打卡
        /// </summary>
        [Display(Name = "自动打卡")] [EnumMember(Value = "AUTO_CHECK")]
        AutoCheck = 7
    }
}