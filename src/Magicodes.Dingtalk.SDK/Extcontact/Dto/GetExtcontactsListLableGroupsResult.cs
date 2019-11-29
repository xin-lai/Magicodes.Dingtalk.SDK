using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Extcontact.Dto
{
    /// <summary>
    /// 获取外部联系人标签列表返回结果
    /// </summary>
    public class GetExtcontactsListLableGroupsResult : ApiResultBase
    {
        /// <summary>
        /// 标签组列表
        /// </summary>
        [JsonProperty("results")]
        public LableGroupList Results { get; set; }
    }

    /// <summary>
    /// 标签组列表
    /// </summary>
    public class LableGroupList
    {
        /// <summary>
        /// 标签组名字
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签组颜色
        /// </summary>
        [JsonProperty("color")]
        public int Color { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("lables")]
        public LableList Lables { get; set; }
    }

    /// <summary>
    /// 标签列表
    /// </summary>
    public class LableList
    {
        /// <summary>
        /// 标签名字
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
