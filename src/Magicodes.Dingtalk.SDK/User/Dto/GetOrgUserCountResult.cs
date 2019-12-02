using Newtonsoft.Json;

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