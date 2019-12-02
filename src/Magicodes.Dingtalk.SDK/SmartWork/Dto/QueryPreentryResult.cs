using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.SmartWork.Dto
{
    /// <summary>
    /// 查询企业待入职员工列表返回结果
    /// </summary>
    public class QueryPreentryResult : ApiResultBase
    {
        /// <summary>
        /// 调用是否成功
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 员工花名册信息结果列表
        /// </summary>
        [JsonProperty("result")]
        public Result ResultInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public class Result
        {
            /// <summary>
            /// 下一次分页调用的offset值，当返回结果里没有nextCursor时，表示分页结束
            /// </summary>
            [JsonProperty("next_cursor")]
            public int? NextCursor { get; set; }

            /// <summary>
            /// 员工userid列表
            /// </summary>
            [JsonProperty("data_list")]
            public List<string> DataList { get; set; }
        }
    }
}
