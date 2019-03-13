// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : ApiResultBase.cs
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

namespace Magicodes.Dingtalk.SDK
{
    public class ApiResultBase
    {
        /// <summary>
        ///     错误消息
        /// </summary>
        [JsonProperty("errmsg")]
        public string ErrorMessage { get; set; }

        /// <summary>
        ///     错误码
        /// </summary>
        [JsonProperty("errcode")]
        public int ErrorCode { get; set; }

        /// <summary>
        ///     是否成功
        /// </summary>
        /// <returns></returns>
        public bool IsSuccess()
        {
            return ErrorCode == 0;
        }
    }
}