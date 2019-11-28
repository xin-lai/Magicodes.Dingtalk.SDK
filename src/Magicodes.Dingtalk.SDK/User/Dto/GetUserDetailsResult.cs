using Newtonsoft.Json;
using SimpleJson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 获取用户详情返回结果
    /// </summary>
    public class GetUserDetailsResult : ApiResultBase
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }

        /// <summary>
        /// 员工名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 对应部门排序
        /// </summary>
        [JsonProperty("orderInDepts")]
        public JsonObject OrderInDepts { get; set; }

        /// <summary>
        /// 所属部门id
        /// </summary>
        [JsonProperty("department")]
        public int[] Department { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }

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
        /// 员工工号
        /// </summary>
        [JsonProperty("jobnumber")]
        public string Jobnumber { get; set; }

        /// <summary>
        /// 是否隐藏号码
        /// </summary>
        [JsonProperty("isHide")]
        public bool isHide { get; set; }

        /// <summary>
        /// 是否为高管
        /// </summary>
        [JsonProperty("isSenior")]
        public bool isSenior { get; set; }

        /// <summary>
        /// 扩展（其他）
        /// </summary>
        [JsonProperty("extattr")]
        public JsonObject Extattr { get; set; }

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
        /// 员工在当前开发者企业账号范围内的唯一标识，系统生成，固定值，不会改变
        /// </summary>
        [JsonProperty("unionid")]
        public string UnionId { get; set; }

        /// <summary>
        /// 是否已经激活，true表示已激活，false表示未激活
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

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
        /// 在对应的部门中是否为主管：Map结构的json字符串，key是部门的Id，value是人员在这个部门中是否为主管，true表示是，false表示不是
        /// </summary>
        [JsonProperty("isLeaderInDepts")]
        public string IsLeaderInDepts { get; set; }

        /// <summary>
        /// 头像url
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 国家地区码
        /// </summary>
        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        /// <summary>
        /// 用户所在角色列表
        /// </summary>
        [JsonProperty("roles")]
        public Role Roles { get; set; }
    }

    /// <summary>
    /// 角色列表
    /// </summary>
    public class Role
    {
        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 角色组名称
        /// </summary>
        [JsonProperty("groupName")]
        public string GroupName { get; set; }
    }
}
