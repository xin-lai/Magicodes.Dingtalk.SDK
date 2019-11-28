using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Department.Dto
{
    /// <summary>
    /// 查询指定用户的所有上级父部门路径返回结果
    /// </summary>
    public class GetDepartmentParentsListByUserIdResult : ApiResultBase
    {
        /// <summary>
        /// 该部门的所有父部门id列表
        /// </summary>
        [JsonProperty("department")]
        public List<List<int>> Department { get; set; }
    }
}
