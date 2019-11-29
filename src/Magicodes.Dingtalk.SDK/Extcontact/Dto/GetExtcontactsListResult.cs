using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.Extcontact.Dto
{
    /// <summary>
    /// 获取外部联系人列表返回结果
    /// </summary>
    public class GetExtcontactsListResult : ApiResultBase
    {
        /// <summary>
        /// 外部联系人
        /// </summary>
        [JsonProperty("result")]
        public List<Extcontacts> Result { get; set; }
    }
}
