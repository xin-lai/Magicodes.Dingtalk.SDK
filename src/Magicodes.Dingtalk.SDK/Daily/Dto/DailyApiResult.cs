// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : DailyApiResult.cs
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

namespace Magicodes.Dingtalk.SDK.Daily.Dto
{
    public class DailyApiResult : ApiResultBase
    {
        /// <summary>
        ///     日志内容
        /// </summary>
        [JsonProperty("data_list")]
        public List<DailyList> DataList { get; set; }

        /// <summary>
        ///     分页大小
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }

        /// <summary>
        ///     下一游标
        /// </summary>
        [JsonProperty("next_cursor")]
        public string NextCursor { get; set; }

        /// <summary>
        ///     是否还有下一页
        /// </summary>
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }
}