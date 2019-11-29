using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Department.Dto
{
    /// <summary>
    /// 查询部门的所有上级父部门路径返回结果
    /// </summary>
    public class GetDepartmentParentsListResult : ApiResultBase
    {
        /// <summary>
        /// 该部门的所有父部门id列表
        /// </summary>
        [JsonProperty("parentIds")]
        public int[] ParentIds { get; set; }
    }
}