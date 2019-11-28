using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 获取部门用户详情
    /// </summary>
    public class GetDeptMemberUserDetailsInput : PageInputBase
    {
        /// <summary>
        /// 通讯录语言(默认zh_CN另外支持en_US)
        /// </summary>
        [JsonProperty("lang")]
        public string Language { get; set; }

        /// <summary>
        /// 获取的部门id，1表示根部门
        /// </summary>
        [JsonProperty("department_id")]
        public long DepartmentId { get; set; }
    }
}
