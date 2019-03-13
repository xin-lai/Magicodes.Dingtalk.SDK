// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : QueryOnJobResult.cs
//           description :
//   
//           created by 雪雁 at  -- 
//           Mail: wenqiang.li@xin-lai.com
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
//           GitHub：https://github.com/xin-lai
//           Home：http://xin-lai.com
//           微信订阅号：magiccodes
//   
// ======================================================================

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.SmartWork.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryOnJobResult: ApiResultBase
    {
        /// <summary>
        ///     下一次分页调用的offset值，当返回结果里没有nextCursor时，表示分页结束
        /// </summary>
        [JsonProperty("next_cursor")]
        public int? NextCursor { get; set; }

        /// <summary>
        /// 分页结果
        /// </summary>
        [JsonProperty("result")]
        public Result ResultInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public class Result
        {
            /// <summary>
            ///     员工userid列表
            /// </summary>
            [JsonProperty("data_list")]
            public List<string> DataList { get; set; }
        }
    }
}