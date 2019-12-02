using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 获取部分用户userid列表
    /// </summary>
    public class GetDeptMemberUsersInput : PageInputBase
    {
        /// <summary>
        /// 通讯录语言(默认zh_CN另外支持en_US)
        /// </summary>
        [JsonProperty("lang")]
        public string Language { get; set; } = "zh_CN";

        /// <summary>
        /// 获取的部门id
        /// </summary>
        [JsonProperty("department_id")]
        public long DepartmentId { get; set; }
    }
}