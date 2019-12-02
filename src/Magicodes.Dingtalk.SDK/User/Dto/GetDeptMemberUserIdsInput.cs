using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 获取部分用户userid列表
    /// </summary>
    public class GetDeptMemberUserIdsInput
    {
        /// <summary>
        /// 部门id
        /// </summary>
        [JsonProperty("deptId")]
        public string DeptId { get; set; }
    }
}