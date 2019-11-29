using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 获取管理员列表返回结果
    /// </summary>
    public class GetAdminsListResult : ApiResultBase
    {
        /// <summary>
        /// 管理员列表
        /// </summary>
        [JsonProperty("admin_list")]
        public List<GetAdmin> AdminList { get; set; }
    }

    /// <summary>
    /// 管理员
    /// </summary>
    public class GetAdmin
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }

        /// <summary>
        /// 管理员角色，1:主管理员，2:子管理员
        /// </summary>
        [JsonProperty("sys_level")]
        public string SysLevel { get; set; }
    }
}