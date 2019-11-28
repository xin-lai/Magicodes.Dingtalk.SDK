using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 获取管理员通讯录权限范围返回结果
    /// </summary>
    public class GetAdminScopeResult : ApiResultBase
    {
        /// <summary>
        /// 可管理的部门id列表
        /// </summary>
        [JsonProperty("hasMore")]
        public int[] DeptIds { get; set; }
    }
}
