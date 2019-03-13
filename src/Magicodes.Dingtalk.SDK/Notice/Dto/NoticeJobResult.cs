// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : NoticeJobResult.cs
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

using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Notice.Dto
{
    public class NoticeJobResult : ApiResultBase
    {
        /// <summary>
        ///     创建的发送任务id
        /// </summary>
        [JsonProperty("task_id")]
        public long task_id { get; set; }
    }
}