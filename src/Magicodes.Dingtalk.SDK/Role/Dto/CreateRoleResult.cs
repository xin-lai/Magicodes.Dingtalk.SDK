using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Role.Dto
{
    /// <summary>
    /// 创建角色返回结果
    /// </summary>
    public class CreateRoleResult:ApiResultBase
    {
        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("roleId")]
        public int RoleId { get; set; }
    }
}
