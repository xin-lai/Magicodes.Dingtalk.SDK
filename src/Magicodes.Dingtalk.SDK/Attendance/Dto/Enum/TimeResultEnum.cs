// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : TimeResultEnum.cs
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
    ///     时间结果
    /// </summary>
    public enum TimeResultEnum
    {
        /// <summary>
        ///     正常
        /// </summary>
        [Display(Name = "正常")] [EnumMember(Value = "Normal")]
        Normal = 0,

        /// <summary>
        ///     早退
        /// </summary>
        [Display(Name = "早退")] [EnumMember(Value = "Early")]
        Early = 1,

        /// <summary>
        ///     迟到
        /// </summary>
        [Display(Name = "迟到")] [EnumMember(Value = "Late")]
        Late = 2,

        /// <summary>
        ///     严重迟到
        /// </summary>
        [Display(Name = "严重迟到")] [EnumMember(Value = "SeriousLate")]
        SeriousLate = 3,

        /// <summary>
        ///     旷工迟到
        /// </summary>
        [Display(Name = "旷工迟到")] [EnumMember(Value = "Absenteeism")]
        Absenteeism = 4,

        /// <summary>
        ///     未打卡
        /// </summary>
        [Display(Name = "未打卡")] [EnumMember(Value = "NotSigned")]
        NotSigned = 5
    }
}