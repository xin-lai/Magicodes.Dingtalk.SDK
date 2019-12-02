using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 获取部门用户userid列表返回结果
    /// </summary>
    public class GetDeptMemberUserIdsResult : ApiResultBase
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [JsonProperty("userids")]
        public string[] UserIds { get; set; }
    }
}