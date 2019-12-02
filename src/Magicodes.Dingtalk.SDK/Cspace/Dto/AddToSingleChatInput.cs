using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Cspace.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class AddToSingleChatInput
    {
        /// <summary>
        /// 文件发送者微应用的agentId
        /// </summary>
        [JsonProperty("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 文件接收人的userid
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }

        /// <summary>
        /// 调用钉盘上传文件接口得到的mediaid，需要utf-8 urlEncode
        /// </summary>
        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// 文件名(需包含扩展名)，需要utf-8 urlEncode
        /// </summary>
        [JsonProperty("file_name")]
        public string FileName { get; set; }
    }
}
