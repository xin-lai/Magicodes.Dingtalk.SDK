using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.File.Dto
{
    /// <summary>
    /// 提交文件上传事务返回结果
    /// </summary>
    public class SubTransactionUploadResult : ApiResultBase
    {
        /// <summary>
        /// 文件存储id
        /// </summary>
        [JsonProperty("media_id")]
        public string MediaId { get; set; }
    }
}
