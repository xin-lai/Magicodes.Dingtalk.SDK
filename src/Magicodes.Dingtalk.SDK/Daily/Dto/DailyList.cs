// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : DailyList.cs
//           description :
//   
//           created by 雪雁 at  2019-03-13 10:05
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
    /// <summary>
    ///     日志
    /// </summary>
    public class DailyList
    {
        /// <summary>
        ///     日志内容
        /// </summary>
        [JsonProperty("contents")]
        public List<Content> Contents { get; set; }

        /// <summary>
        ///     备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        ///     日志模板名
        /// </summary>
        [JsonProperty("template_name")]
        public string TemplatNname { get; set; }

        /// <summary>
        ///     部门
        /// </summary>
        [JsonProperty("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        ///     日志创建人
        /// </summary>
        [JsonProperty("creator_name")]
        public string CreatorName { get; set; }

        /// <summary>
        ///     日志创建人userid
        /// </summary>
        [JsonProperty("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        ///     日志创建时间
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        ///     日志唯一id
        /// </summary>
        [JsonProperty("report_id")]
        public string ReportId { get; set; }
    }
}