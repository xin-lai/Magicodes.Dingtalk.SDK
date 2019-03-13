// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : ListResult.cs
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

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Attendance.Dto
{
    /// <summary>
    ///     打卡详情结果
    /// </summary>
    public class AttendanceListResult : ApiResultBase
    {
        [JsonProperty("recordresult")]
        public List<RecordDetailResult> RecordResult { get; set; }

        /// <summary>
        /// 分页返回参数，表示是否还有更多数据
        /// </summary>
        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
    }
}