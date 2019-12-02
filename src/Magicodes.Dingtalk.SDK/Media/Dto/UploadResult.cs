using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Media.Dto
{
    /// <summary>
    /// 上传媒体文件返回结果
    /// </summary>
    public class UploadResult : ApiResultBase
    {
        /// <summary>
        /// 媒体文件类型，分别有图片（image）、语音（voice）、普通文件(file)
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 媒体文件上传后获取的唯一标识
        /// </summary>
        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// 媒体文件上传时间
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreateAtTime { get; set; }

        /// <summary>
        /// 媒体文件上传时间戳
        /// </summary>
        private string CreatedAt { get; set; }
    }
}
