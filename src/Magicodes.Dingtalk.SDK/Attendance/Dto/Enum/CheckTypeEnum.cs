// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : CheckTypeEnum.cs
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
    ///     考勤类型
    /// </summary>
    public enum CheckTypeEnum
    {
        /// <summary>
        ///     上班
        /// </summary>
        [Display(Name = "上班")] [EnumMember(Value = "OnDuty")]
        OnDuty = 0,

        /// <summary>
        ///     下班
        /// </summary>
        [Display(Name = "下班")] [EnumMember(Value = "OffDuty")]
        OffDuty = 1
    }
}