using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Role.Dto
{
    /// <summary>
    /// 获取角色列表返回结果
    /// </summary>
    public class GetRoleUsersListResult : ApiResultBase
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [JsonProperty("result")]
        public UserList Result { get; set; }
    }

    /// <summary>
    /// 员工集合
    /// </summary>
    public class UserList
    {
        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 下次拉取数据的游标
        /// </summary>
        [JsonProperty("nextCursor")]
        public int NextCursor { get; set; }

        /// <summary>
        /// 集合
        /// </summary>
        [JsonProperty("list")]
        public List<User> List { get; set; }
}

    /// <summary>
    /// 员工
    /// </summary>
    public class User
    {
        /// <summary>
        /// 员工姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [JsonProperty("userid")]
        public int Userid { get; set; }
    }
}
