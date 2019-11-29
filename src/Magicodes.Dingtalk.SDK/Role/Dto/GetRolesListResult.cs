using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Role.Dto
{
    /// <summary>
    /// 获取角色列表返回结果
    /// </summary>
    public class GetRolesListResult : ApiResultBase
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [JsonProperty("result")]
        public RolesList Result { get; set; }
    }

    /// <summary>
    /// 角色集合
    /// </summary>
    public class RolesList
    {
        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 集合
        /// </summary>
        [JsonProperty("list")]
        public List<RolesGroup> List { get; set; }
}

    /// <summary>
    /// 角色组
    /// </summary>
    public class RolesGroup
    {
        /// <summary>
        /// 角色组名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 角色组id
        /// </summary>
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [JsonProperty("roles")]
        public List<Role> Roles { get; set; }
    }

    /// <summary>
    /// 角色
    /// </summary>
    public class Role
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("name")]
        public int Id { get; set; }
    }
}
