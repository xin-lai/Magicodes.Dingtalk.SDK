// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : Content.cs
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

using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Daily.Dto
{
    /// <summary>
    ///     日志内容
    /// </summary>
    public class Content
    {
        /// <summary>
        ///     排序
        /// </summary>
        [JsonProperty("sort")]
        public int Sort { get; set; }

        /// <summary>
        ///     类型
        /// </summary>
        [JsonProperty("type")]
        public DailyTypes Types { get; set; }

        /// <summary>
        ///     用户填写的内容
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        ///     模板内容
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}