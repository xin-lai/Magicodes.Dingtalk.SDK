// ======================================================================
//
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司
//           All rights reserved
//
//           filename : DailyApiResult.cs
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
using SimpleJson;
using System;
using System.ComponentModel.DataAnnotations;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 创建或修改员工
    /// </summary>
    public class CreateOrEditUsersInput
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [StringLength(64, MinimumLength = 1)]
        [JsonProperty("userid")]
        public string UserId { get; set; }

        /// <summary>
        /// 员工名称
        /// </summary>
        [StringLength(64, MinimumLength = 1)]
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
        [StringLength(64, MinimumLength = 0)]
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
        [StringLength(50, MinimumLength = 0)]
        [JsonProperty("tel")]
        public string Tel { get; set; }

        /// <summary>
        /// 办公地点
        /// </summary>
        [StringLength(50, MinimumLength = 0)]
        [JsonProperty("workPlace")]
        public string WorkPlace { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(1000, MinimumLength = 0)]
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [StringLength(64, MinimumLength = 0)]
        [RegularExpression(@"^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$")]
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 员工的企业邮箱
        /// </summary>
        [RegularExpression(@"^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$")]
        [JsonProperty("orgEmail")]
        public String OrgEmail { get; set; }

        /// <summary>
        /// 员工工号
        /// </summary>
        [StringLength(64, MinimumLength = 0)]
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
    }
}