using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Extcontact.Dto
{
    /// <summary>
    /// 创建外部联系人返回结果
    /// </summary>
    public class CreateExtcontactResult : ApiResultBase
    {
        /// <summary>
        /// 新外部联系人的userid
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }
    }
}