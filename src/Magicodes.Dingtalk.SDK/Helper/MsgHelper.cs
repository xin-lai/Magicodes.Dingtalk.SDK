// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : MsgHelper.cs
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

namespace Magicodes.Dingtalk.SDK.Helper
{
    /// <summary>
    ///     文本消息
    /// </summary>
    public class MsgHelper
    {
        /// <summary>
        ///     消息类型，此时固定为：text
        /// </summary>
        [JsonProperty("msgtype")]
        public string Msgtype { get; set; }

        /// <summary>
        ///     消息内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}