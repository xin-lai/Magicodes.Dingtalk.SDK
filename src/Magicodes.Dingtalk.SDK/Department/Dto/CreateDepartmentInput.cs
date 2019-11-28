using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Department.Dto
{
    /// <summary>
    /// 创建部门
    /// </summary>
    public class CreateDepartmentInput
    {
        /// <summary>
        /// 部门名称，长度限制为1~64个字符，不允许包含字符‘-’‘，’以及‘,’
        /// </summary>
        [RegularExpression(@"[^-,\x22]+")]
        [StringLength(64, MinimumLength = 1)]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父部门id，根部门id为1
        /// </summary>
        [JsonProperty("parentid")]
        public string ParentId { get; set; }

        /// <summary>
        /// 在父部门中的排序值，order值小的排序靠前
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }

        /// <summary>
        /// 是否创建一个关联此部门的企业群，默认为false
        /// </summary>
        [JsonProperty("createDeptGroup")]
        public bool? CreateDeptGroup { get; set; }

        /// <summary>
        /// 是否隐藏部门,true表示隐藏,false表示显示
        /// </summary>
        [JsonProperty("deptHiding")]
        public bool? DeptHiding { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他部门列表，如果部门隐藏，则此值生效，取值为其他的部门id组成的字符串，使用“\|”符号进行分割。总数不能超过200
        /// </summary>
        [JsonProperty("deptPermits")]
        public string DeptPermits { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他人员列表，如果部门隐藏，则此值生效，取值为其他的人员userid组成的的字符串，使用“\|”符号进行分割。总数不能超过200
        /// </summary>
        [JsonProperty("userPermits")]
        public string UserPermits { get; set; }

        /// <summary>
        /// 限制本部门成员查看通讯录，限制开启后，本部门成员只能看到限定范围内的通讯录。true表示限制开启
        /// </summary>
        [JsonProperty("outerDept")]
        public bool? OuterDept { get; set; }

        /// <summary>
        /// outerDept为true时，可以配置额外可见部门，值为部门id组成的的字符串，使用“\|”符号进行分割。总数不能超过200
        /// </summary>
        [JsonProperty("outerPermitDepts")]
        public string OuterPermitDepts { get; set; }


        /// <summary>
        /// outerDept为true时，可以配置额外可见人员，值为userid组成的的字符串，使用“\|”符号进行分割。总数不能超过200
        /// </summary>
        [JsonProperty("outerPermitUsers")]
        public string OuterPermitUsers { get; set; }

        /// <summary>
        /// outerDept为true时，可以配置该字段，为true时，表示只能看到所在部门及下级部门通讯录
        /// </summary>
        [JsonProperty("outerDeptOnlySelf")]
        public bool? OuterDeptOnlySelf { get; set; }

        /// <summary>
        /// 部门标识字段，开发者可用该字段来唯一标识一个部门，并与钉钉外部通讯录里的部门做映射
        /// </summary>
        [JsonProperty("sourceIdentifier")]
        public string SourceIdentifier { get; set; }
    }
}
