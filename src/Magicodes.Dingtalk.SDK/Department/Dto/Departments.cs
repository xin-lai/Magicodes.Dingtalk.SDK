// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : Departments.cs
//           description :
//   
//           created by 雪雁 at  2019-03-13 10:05
//           Mail: wenqiang.li@xin-lai.com
//           QQ群：85318032（技术交流）
//           Blog：http://www.cnblogs.com/codelove/
//           GitHub：https://github.com/xin-lai
//           Home：http://xin-lai.com
//   
// ======================================================================

using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Department.Dto
{
    public class Departments
    {
        /// <summary>
        ///     部门id
        /// </summary>
        [JsonProperty("id")]
        public long DepartmentId { get; set; }

        /// <summary>
        ///     部门名称
        /// </summary>
        [JsonProperty("name")]
        public string DepartmentName { get; set; }

        /// <summary>
        ///     父部门id，根部门为1
        /// </summary>
        [JsonProperty("parentid")]
        public long ParentId { get; set; }

        /// <summary>
        ///     是否同步创建一个关联此部门的企业群，true表示是，false表示不是
        /// </summary>
        [JsonProperty("createDeptGroup")]
        public bool CreateDeptGroup { get; set; }

        /// <summary>
        ///     当群已经创建后，是否有新人加入部门会自动加入该群, true表示是，false表示不是
        /// </summary>
        [JsonProperty("autoAddUser")]
        public bool AutoAddUser { get; set; }
    }
}