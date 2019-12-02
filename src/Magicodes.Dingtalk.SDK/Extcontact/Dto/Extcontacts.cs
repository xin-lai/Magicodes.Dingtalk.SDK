using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Extcontact.Dto
{
    /// <summary>
    /// 外部联系人
    /// </summary>
    public class Extcontacts
    {
        /// <summary>
        /// 职位
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 共享部门ID列表
        /// </summary>
        [JsonProperty("share_dept_ids")]
        public int?[] ShareDeptIds { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("label_ids")]
        public int[] LabelIds { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 负责人UserID
        /// </summary>
        [JsonProperty("follower_user_id")]
        public string FollowerUserId { get; set; }

        /// <summary>
        /// 国家码
        /// </summary>
        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        /// <summary>
        /// 公司名
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 共享员工UserID列表
        /// </summary>
        [JsonProperty("share_user_ids")]
        public string[] ShareUserIds { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 外部联系人UserID
        /// </summary>
        [JsonProperty("userid")]
        public string UserId { get; set; }
    }
}