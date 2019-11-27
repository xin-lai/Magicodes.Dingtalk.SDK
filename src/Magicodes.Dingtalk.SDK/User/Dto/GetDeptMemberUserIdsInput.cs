using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 获取部分用户userid列表
    /// </summary>
    public class GetDeptMemberUserIdsInput
    {
        /// <summary>
        /// 接口凭证 
        /// </summary>
        [JsonProperty("access_token")]
        public string Access_Token { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        [JsonProperty("deptId")]
        public string DeptId { get; set; }
    }
}
