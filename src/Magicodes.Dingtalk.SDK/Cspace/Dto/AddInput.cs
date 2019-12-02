using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Cspace.Dto
{
    /// <summary>
    /// 新增文件到用户自定义控件
    /// </summary>
    public class AddInput
    {
        /// <summary>
        /// 微应用的agentId
        /// </summary>
        [JsonProperty("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// code值为应用免登授权码, 微应用授权码参考文档，小程序授权码参考文档
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 调用钉盘上传文件接口得到的mediaid，需要utf-8 urlEncode
        /// </summary>
        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// 调用钉盘获取企业自定义空间接口、获取审批钉盘空间获取的钉盘空间ID
        /// </summary>
        [JsonProperty("space_id")]
        public string SpaceId { get; set; }

        /// <summary>
        /// 调用钉盘选择控件后获取的用户钉盘文件夹ID。如接入审批附件，这里传0
        /// </summary>
        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        /// <summary>
        /// 上传文件的名称，不能包含非法字符，需要utf-8 urlEncode
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 遇到同名文件是否覆盖，若不覆盖，则会自动重命名本次新增的文件，默认为false
        /// </summary>
        [JsonProperty("overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// 文件上传的路径，如根目录传"/"，/doc文件夹传"/doc/"，需要utf-8 urlEncode
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }
    }
}
