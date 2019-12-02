using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Cspace.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class GrantCustomSpaceInput
    {
        /// <summary>
        /// ISV调用时传入，授权访问指定微应用的自定义空间
        /// </summary>
        [JsonProperty("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 企业内部调用时传入，授权访问该domain的自定义空间
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 权限类型，目前支持上传和下载，上传请传add，下载请传download
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 企业用户userid
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }

        /// <summary>
        /// 授权访问的路径，如授权访问所有文件传"/"，授权访问/doc文件夹传"/doc/"，需要utf-8 urlEncode, type=add时必须传递
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// 授权访问的文件id列表，id之间用英文逗号隔开，如"fileId1,fileId2", type=download时必须传递
        /// </summary>
        [JsonProperty("fileids")]
        public string Fileids { get; set; }

        /// <summary>
        /// 权限有效时间，有效范围为0~3600秒
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }
    }
}
