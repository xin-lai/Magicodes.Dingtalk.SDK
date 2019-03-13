// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : DateTimeHelper.cs
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
    /// <summary>
    ///     微信时间戳转换
    /// </summary>
    public static class DateTimeHelper
    {
        /// <summary>
        ///     定义格林威治时间
        /// </summary>
        private static readonly DateTime startTime = new DateTime(1970, 1, 1, 8, 00, 00);

        /// <summary>
        ///     转换为时间戳
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long ConvertToTimeStamp(this DateTime time)
        {
            return (long) (time - startTime).TotalMilliseconds;
        }

        /// <summary>
        ///     转换为时间
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public static DateTime ConvertToDateTime(this long timestamp)
        {
            return startTime.AddMilliseconds(timestamp);
        }
    }
}