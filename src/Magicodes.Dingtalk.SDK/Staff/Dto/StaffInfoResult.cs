// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : StaffInfoResult.cs
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

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Staff.Dto
{
    public class StaffInfoResult : ApiResultBase
    {
        /// <summary>
        ///     下一次分页调用的offset值，当返回结果里没有nextCursor时，表示分页结束
        /// </summary>
        [JsonProperty("next_cursor")]
        public int NextCursor { get; set; }

        /// <summary>
        ///     员工userid列表
        /// </summary>
        [JsonProperty("data_list")]
        public List<string> DataList { get; set; }
    }
}