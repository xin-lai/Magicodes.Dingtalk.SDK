using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 根据手机号获取userid返回结果
    /// </summary>
    public class GetUserIdByMobileResult : ApiResultBase
    {
        /// <summary>
        /// 员工在当前企业内的唯一标识。
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }
    }
}