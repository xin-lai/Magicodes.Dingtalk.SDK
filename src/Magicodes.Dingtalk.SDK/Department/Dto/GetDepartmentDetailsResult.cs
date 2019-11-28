using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Department.Dto
{
    /// <summary>
    /// 获取部门详情返回结果
    /// </summary>
    public class GetDepartmentDetailsResult:ApiResultBase
    {
        /// <summary>
        /// 部门id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 部门名称，长度限制为1~64个字符，不允许包含字符‘-’‘，’以及‘,’
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父部门id，根部门id为1
        /// </summary>
        [JsonProperty("parentid")]
        public string ParentId { get; set; }

        /// <summary>
        /// 当前部门在父部门下的所有子部门中的排序值
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }


        /// <summary>
        /// 是否同步创建一个关联此部门的企业群，true表示是，false表示不是
        /// </summary>
        [JsonProperty("createDeptGroup")]
        public bool? CreateDeptGroup { get; set; }

        /// <summary>
        /// 当部门群已经创建后，是否有新人加入部门会自动加入该群，true表示是，false表示不是
        /// </summary>
        [JsonProperty("autoAddUser")]
        public bool? AutoAddUser { get; set; }

        /// <summary>
        /// 是否隐藏部门，true表示隐藏，false表示显示
        /// </summary>
        [JsonProperty("deptHiding")]
        public bool? DeptHiding { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他部门列表，如果部门隐藏，则此值生效，取值为其他的部门id组成的的字符串，使用“\|”符号进行分割
        /// </summary>
        [JsonProperty("deptPermits")]
        public string DeptPermits { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他人员列表，如果部门隐藏，则此值生效，取值为其他的人员userid组成的的字符串，使用“\|”符号进行分割
        /// </summary>
        [JsonProperty("userPermits")]
        public string UserPermits { get; set; }

        /// <summary>
        /// 是否本部门的员工仅可见员工自己，为true时，本部门员工默认只能看到员工自己
        /// </summary>
        [JsonProperty("outerDept")]
        public bool? OuterDept { get; set; }

        /// <summary>
        /// 本部门的员工仅可见员工自己为true时，可以配置额外可见部门，值为部门id组成的的字符串，使用“\|”符号进行分割
        /// </summary>
        [JsonProperty("outerPermitDepts")]
        public string OuterPermitDepts { get; set; }


        /// <summary>
        /// 本部门的员工仅可见员工自己为true时，可以配置额外可见人员，值为userid组成的的字符串，使用“\|”符号进行分割
        /// </summary>
        [JsonProperty("outerPermitUsers")]
        public string OuterPermitUsers { get; set; }

        /// <summary>
        /// 企业群群主
        /// </summary>
        [JsonProperty("orgDeptOwner")]
        public string OrgDeptOwner { get; set; }

        /// <summary>
        /// 部门的主管列表，取值为由主管的userid组成的字符串，不同的userid使用“\|”符号进行分割
        /// </summary>
        [JsonProperty("deptManagerUseridList")]
        public string DeptManagerUseridList { get; set; }

        /// <summary>
        /// 部门标识字段，开发者可用该字段来唯一标识一个部门，并与钉钉外部通讯录里的部门做映射
        /// </summary>
        [JsonProperty("sourceIdentifier")]
        public string SourceIdentifier { get; set; }


        /// <summary>
        /// 部门群是否包含子部门
        /// </summary>
        [JsonProperty("groupContainSubDept")]
        public bool? GroupContainSubDept { get; set; }
    }
}
