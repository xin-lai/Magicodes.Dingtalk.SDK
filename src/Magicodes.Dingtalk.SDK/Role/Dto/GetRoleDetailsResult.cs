using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Role.Dto
{
    /// <summary>
    /// 获取角色详情返回结果
    /// </summary>
    public class GetRoleDetailsResult : ApiResultBase
    {
        /// <summary>
        /// 角色信息
        /// </summary>
        [JsonProperty("role")]
        public RoleDetails Role { get; set; }
    }

    /// <summary>
    /// 角色信息
    /// </summary>
    public class RoleDetails
    {
        /// <summary>
        /// 角色名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 角色组id
        /// </summary>
        [JsonProperty("groupId")]
        public int GroupId { get; set; }
    }
}
