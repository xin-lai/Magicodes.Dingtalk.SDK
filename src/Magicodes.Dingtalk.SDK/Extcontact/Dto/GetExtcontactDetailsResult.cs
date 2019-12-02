using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Extcontact.Dto
{
    /// <summary>
    /// 获取外部联系人详情返回结果
    /// </summary>
    public class GetExtcontactDetailsResult : ApiResultBase
    {
        /// <summary>
        /// 外部联系人
        /// </summary>
        [JsonProperty("result")]
        public Extcontacts Result { get; set; }
    }
}