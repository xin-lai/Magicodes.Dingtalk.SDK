using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.File.Dto
{
    /// <summary>
    /// 开启分块上传事务返回结果
    /// </summary>
    public class TransactionUploadResult : ApiResultBase
    {
        /// <summary>
        /// 上传事务id
        /// </summary>
        [JsonProperty("upload_id")]
        public string UploadId { get; set; }
    }
}
