using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 根据unionid获取userid返回结果
    /// </summary>
    public class GetUserIdByUnionidResult : ApiResultBase
    {
        /// <summary>
        /// 联系类型，0表示企业内部员工，1表示企业外部联系人
        /// </summary>
        [JsonProperty("contactType")]
        public int ContactType { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [JsonProperty("userid")]
        public string Userid { get; set; }
    }
}