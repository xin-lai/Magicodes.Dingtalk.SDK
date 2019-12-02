using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 创建员工返回结果
    /// </summary>
    public class CreateUserResult : ApiResultBase
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }
    }
}