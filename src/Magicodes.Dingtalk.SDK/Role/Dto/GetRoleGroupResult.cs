using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Role.Dto
{
    /// <summary>
    /// 获取角色组返回结果
    /// </summary>
    public class GetRoleGroupResult : ApiResultBase
    {
        /// <summary>
        /// 角色组信息
        /// </summary>
        [JsonProperty("role_group")]
        public RoleGroup RoleGroup { get; set; }
    }

    /// <summary>
    /// 角色组信息
    /// </summary>
    public class RoleGroup
    {
        /// <summary>
        /// 角色列表信息
        /// </summary>
        [JsonProperty("roles")]
        public List<GetRoleGroup> Roles { get; set; }

        /// <summary>
        /// 角色组名
        /// </summary>
        [JsonProperty("group_name")]
        public string GroupName { get; set; }
    }

    /// <summary>
    /// 角色列表
    /// </summary>
    public class GetRoleGroup
    {
        /// <summary>
        /// 角色名
        /// </summary>
        [JsonProperty("role_name")]
        public string RoleName { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("role_id")]
        public int RoleId { get; set; }
    }
}
