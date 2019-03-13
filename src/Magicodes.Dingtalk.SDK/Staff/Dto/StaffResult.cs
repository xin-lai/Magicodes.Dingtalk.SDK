// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : StaffResult.cs
//           description :
//   
//           created by 雪雁 at  2019-03-13 10:03
//           Mail: wenqiang.li@xin-lai.com
//           QQ群：85318032（技术交流）
//           Blog：http://www.cnblogs.com/codelove/
//           GitHub：https://github.com/xin-lai
//           Home：http://xin-lai.com
//   
// ======================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Magicodes.Dingtalk.SDK.Staff.Dto
{
    public class StaffResult : ApiResultBase
    {
        /// <summary>
        ///     员工在当前开发者企业账号范围内的唯一标识，系统生成，固定值，不会改变
        /// </summary>
        [JsonProperty("unionid")]
        public string UnionId { get; set; }

        /// <summary>
        ///     备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        ///     员工在当前企业内的唯一标识，也称staffId。可由企业在创建时指定，并代表一定含义比如工号，创建后不可修改
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }

        /// <summary>
        ///     在对应的部门中是否为主管：Map结构的json字符串，key是部门的Id，value是人员在这个部门中是否为主管，true表示是，false表示不是
        /// </summary>
        [JsonProperty("isLeaderInDepts")]
        public string IsLeaderInDepts { get; set; }

        /// <summary>
        ///     是否为企业的老板，true表示是，false表示不是
        /// </summary>
        [JsonProperty("isBoss")]
        public bool IsBoss { get; set; }

        /// <summary>
        ///     入职时间
        /// </summary>
        [JsonProperty("hiredDate")]
        public long HiredDate { get; set; }

        /// <summary>
        ///     是否高管模式，true表示开启。开启后，手机号码对所有员工隐藏。普通员工无法对其发DING、发起钉钉免费商务电话。高管之间不受影响
        /// </summary>
        [JsonProperty("isSenior")]
        public bool IsSenior { get; set; }

        /// <summary>
        ///     分机号（仅限企业内部开发调用）
        /// </summary>
        [JsonProperty("tel")]
        public string Tel { get; set; }

        /// <summary>
        ///     成员所属部门id列表
        /// </summary>
        [JsonProperty("department")]
        public long[] Department { get; set; }

        /// <summary>
        ///     办公地点
        /// </summary>
        [JsonProperty("workPlace")]
        public string WorkPlace { get; set; }

        /// <summary>
        ///     员工的邮箱
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        ///     在对应的部门中的排序,Map结构的json字符串, key是部门的Id, value是人员在这个部门的排序值
        /// </summary>
        [JsonProperty("orderInDepts")]
        public string OrderInDepts { get; set; }

        /// <summary>
        ///     手机号码，企业内必须唯一，不可重复
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        ///     是否已经激活，true表示已激活，false表示未激活
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        ///     头像url
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        ///     是否是企业的管理员，true表示是，false表示不是
        /// </summary>
        [JsonProperty("isAdmin")]
        public bool IsAdmin { get; set; }

        /// <summary>
        ///     是否号码隐藏,true表示隐藏,隐藏手机号后，手机号在个人资料页隐藏，但仍可对其发DING、发起钉钉免费商务电话。
        /// </summary>
        [JsonProperty("isHide")]
        public bool IsHide { get; set; }

        /// <summary>
        ///     员工工号。对应显示到OA后台和客户端个人资料的工号栏目
        /// </summary>
        [JsonProperty("jobnumber")]
        public string JobNumber { get; set; }

        /// <summary>
        ///     成员名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     扩展属性，可以设置多种属性（但手机上最多只能显示10个扩展属性，具体显示哪些属性，请到OA管理后台->设置->通讯录信息设置和OA管理后台->设置->手机端显示信息设置）
        /// </summary>
        [JsonProperty("extattr")]
        public JObject Extattr { get; set; }

        /// <summary>
        ///     状态码
        /// </summary>
        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        /// <summary>
        ///     职位信息
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }
    }
}