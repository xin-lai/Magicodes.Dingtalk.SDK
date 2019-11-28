using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Department.Dto
{
    /// <summary>
    /// 获取子部门ID列表返回结果
    /// </summary>
    public class GetDepartmentParentsListByDeptIdResult : ApiResultBase
    {
        /// <summary>
        /// 子部门ID列表数据
        /// </summary>
        [JsonProperty("GetSubDepartmentListIds")]
        public int[] SubDepartmentListIds { get; set; }
    }
}
