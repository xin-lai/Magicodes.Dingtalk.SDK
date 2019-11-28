using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    public class GetOrgUserCountResult : ApiResultBase
    {
        /// <summary>
        /// 企业员工数量
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
