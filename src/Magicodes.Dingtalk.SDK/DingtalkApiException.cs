// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : DingtalkApiException.cs
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

using System;

namespace Magicodes.Dingtalk.SDK
{
    public class DingtalkApiException : Exception
    {
        private readonly int _code;

        public DingtalkApiException()
        {
        }

        public DingtalkApiException(string message) : base(message)
        {
        }

        public DingtalkApiException(int code, string message) : base(message)
        {
            _code = code;
        }

        public DingtalkApiException(int code, string message, Exception innerException) : base(message, innerException)
        {
            _code = code;
        }

        public override string ToString()
        {
            if (_code == 0) return base.ToString();
            return "ErrorCode:" + _code + Environment.NewLine + base.ToString();
        }
    }
}