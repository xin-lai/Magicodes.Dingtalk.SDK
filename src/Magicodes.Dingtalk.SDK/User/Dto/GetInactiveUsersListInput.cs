using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 未登录钉钉的员工列表
    /// </summary>
    public class GetInactiveUsersListInput : PageInputBase
    {
        /// <summary>
        /// 查询日期
        /// </summary>
        [JsonProperty("query_date")]
        public string QueryDate { get; set; }
    }
}