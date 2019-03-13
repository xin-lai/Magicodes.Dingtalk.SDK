// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : TimeZoneHelper.cs
//           description :
//   
//           created by 雪雁 at  2019-03-13 10:05
//           Mail: wenqiang.li@xin-lai.com
//           QQ群：85318032（技术交流）
//           Blog：http://www.cnblogs.com/codelove/
//           GitHub：https://github.com/xin-lai
//           Home：http://xin-lai.com
//   
// ======================================================================

using System;

namespace Magicodes.Dingtalk.SDK.Helper
{
    public class TimeZoneHelper
    {
        public static DateTime GetChinaDateTime(DateTime? time = null)
        {
            if (!time.HasValue)
                time = DateTime.Now;
            return time.Value.ToUniversalTime().AddHours(8);
        }
    }
}