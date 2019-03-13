// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : ListRecordResult.cs
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
    ///     打卡结果
    /// </summary>
    public class ListRecordResult : ApiResultBase
    {
        [JsonProperty("recordresult")] public List<RecordResult> RecordResult { get; set; }
    }
}