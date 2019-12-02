using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.SmartWork.Dto
{
    /// <summary>
    /// 获取员工花名册字段信息返回结果
    /// </summary>

    public class GetHrmListInfoResult : ApiResultBase
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
        /// 员工花名册信息结果列表
        /// </summary>
        public class Result
        {
            /// <summary>
            /// 员工唯一标识ID
            /// </summary>
            [JsonProperty("userid")]
            public string UserId { get; set; }

            /// <summary>
            /// 花名册字段列表
            /// </summary>
            [JsonProperty("field_list")]
            public FiledList FiledListInfo { get; set; }

            /// <summary>
            /// 花名册字段列表
            /// </summary>
            public class FiledList
            {
                /// <summary>
                /// 字段分组id
                /// </summary>
                [JsonProperty("groupId")]
                public string GroupId { get; set; }

                /// <summary>
                /// 字段的值
                /// </summary>
                [JsonProperty("value")]
                public string Value { get; set; }

                /// <summary>
                /// 对应value的文本值（value枚举值时，label取值为value的文本翻译；否则，label取值同value）
                /// </summary>
                [JsonProperty("label")]
                public string Label { get; set; }

                /// <summary>
                /// 字段编码
                /// </summary>
                [JsonProperty("fieldCode")]
                public string FiledCode { get; set; }

                /// <summary>
                /// 字段业务名称
                /// </summary>
                [JsonProperty("fieldName")]
                public string FiledName { get; set; }
            }
        }
    }
}
