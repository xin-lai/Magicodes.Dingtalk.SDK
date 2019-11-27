using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 获取用户详情
    /// </summary>
    public class GetUserDetailsInput
    {
        /// <summary>
        /// 接口凭证 
        /// </summary>
        [JsonProperty("access_token")]
        public string Access_Token { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [StringLength(64, MinimumLength = 1)]
        [JsonProperty("userid")]
        public string UserId { get; set; }

        /// <summary>
        /// 通讯录语言(默认zh_CN，未来会支持en_US)
        /// </summary>
        [JsonProperty("lang")]
        public string Language { get; set; }
    }
}
