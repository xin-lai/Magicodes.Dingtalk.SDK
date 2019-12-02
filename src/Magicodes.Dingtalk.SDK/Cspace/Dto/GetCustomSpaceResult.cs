using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Cspace.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class GetCustomSpaceResult : ApiResultBase
    {
        /// <summary>
        /// 获取到的空间id
        /// </summary>
        [JsonProperty("spaceid")]
        public string SpaceId { get; set; }
    }
}
