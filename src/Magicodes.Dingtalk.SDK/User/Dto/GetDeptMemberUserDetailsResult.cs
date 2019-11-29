using Newtonsoft.Json;
using SimpleJson;
using System;
using System.Collections.Generic;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 获取部门用户详情返回结果
    /// </summary>
    public class GetDeptMemberUserDetailsResult : ApiResultBase
    {
        /// <summary>
        /// 在分页查询时返回，代表是否还有下一页更多数据
        /// </summary>
        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 成员列表
        /// </summary>
        [JsonProperty("userlist")]
        public List<MemberUser> UserList { get; set; }
    }

    /// <summary>
    /// 部门用户
    /// </summary>
    public class MemberUser
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }

        /// <summary>
        /// 员工在当前开发者企业账号范围内的唯一标识，系统生成，固定值，不会改变
        /// </summary>
        [JsonProperty("unionid")]
        public string UnionId { get; set; }

        /// <summary>
        /// 表示人员在此部门中的排序，列表是按order的倒序排列输出的，即从大到小排列输出的
        ///（钉钉管理后台里面调整了顺序的话order才有值）
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 分机号
        /// </summary>
        [JsonProperty("tel")]
        public string Tel { get; set; }

        /// <summary>
        /// 办公地点
        /// </summary>
        [JsonProperty("workPlace")]
        public string WorkPlace { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 是否是企业的管理员，true表示是，false表示不是
        /// </summary>
        [JsonProperty("isAdmin")]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// 是否为企业的老板，true表示是，false表示不是
        /// </summary>
        [JsonProperty("isBoss")]
        public bool IsBoss { get; set; }

        /// <summary>
        /// 是否是部门的主管，true表示是，false表示不是
        /// </summary>
        [JsonProperty("isLeader")]
        public bool IsLeader { get; set; }

        /// <summary>
        /// 员工名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 表示该用户是否激活了钉钉
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// 成员所属部门id列表
        /// </summary>
        [JsonProperty("department")]
        public int[] Department { get; set; }

        /// <summary>
        /// 职位信息
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 员工的企业邮箱
        /// </summary>
        [JsonProperty("orgEmail")]
        public String OrgEmail { get; set; }

        /// <summary>
        /// 头像url
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 员工工号
        /// </summary>
        [JsonProperty("jobnumber")]
        public string Jobnumber { get; set; }

        /// <summary>
        /// 入职时间
        /// </summary>
        [JsonProperty("hiredDate")]
        public DateTime? HiredDateTime { get; set; }

        /// <summary>
        /// 入职时间 时间戳
        /// </summary>
        public long? HiredDate { get; set; }

        /// <summary>
        /// 扩展（其他）
        /// </summary>
        [JsonProperty("extattr")]
        public JsonObject Extattr { get; set; }

        /// <summary>
        /// 国家地区码
        /// </summary>
        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
    }
}