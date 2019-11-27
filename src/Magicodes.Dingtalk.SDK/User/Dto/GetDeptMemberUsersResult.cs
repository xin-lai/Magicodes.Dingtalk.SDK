using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 获取部门用户userid列表返回结果
    /// </summary>
    public class GetDeptMemberUsersResult : ApiResultBase
    {
        /// <summary>
        /// 在分页查询时返回，代表是否还有下一页更多数据
        /// </summary>
        [JsonProperty("hasMore")]
        public bool hasMore { get; set; }

        /// <summary>
        /// 成员列表
        /// </summary>
        [JsonProperty("userlist")]
        public List<User> Userlist { get; set; }
    }

    /// <summary>
    /// 成员
    /// </summary>
    public class User
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }

        /// <summary>
        /// 成员名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
