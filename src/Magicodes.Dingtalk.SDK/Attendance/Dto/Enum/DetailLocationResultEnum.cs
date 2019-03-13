// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : DetailLocationResultEnum.cs
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
    ///     RecordDetailResult 的位置结果
    /// </summary>
    public enum DetailLocationResultEnum
    {
        /// <summary>
        ///     范围内
        /// </summary>
        [Display(Name = "范围内")] [EnumMember(Value = "Normal")]
        Normal = 0,

        /// <summary>
        ///     范围外
        /// </summary>
        [Display(Name = "范围外")] [EnumMember(Value = "Outside")]
        Outside = 1,

        /// <summary>
        ///     未打卡
        /// </summary>
        [Display(Name = "未打卡")] [EnumMember(Value = "NotSigned")]
        NotSigned = 2
    }
}