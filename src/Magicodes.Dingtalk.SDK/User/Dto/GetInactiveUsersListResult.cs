using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 未登录钉钉的员工列表返回结果
    /// </summary>
    public class GetInactiveUsersListResult : ApiResultBase
    {
        /// <summary>
        /// 未登录钉钉的员工列表返回
        /// </summary>
        [JsonProperty("result")]
        public GetInactiveUsers Result { get; set; }
    }

    /// <summary>
    /// 未登录钉钉的员工列表
    /// </summary>
    public class GetInactiveUsers
    {
        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 未登录用户userId列表
        /// </summary>
        [JsonProperty("list")]
        public string[] UserIdList { get; set; }
    }
}