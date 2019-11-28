using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Department.Dto
{
    /// <summary>
    /// 创建或者修改部门返回结果
    /// </summary>
    public class CreateOrUpdateDepartmentResult :ApiResultBase
    {
        /// <summary>
        /// 部门id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
