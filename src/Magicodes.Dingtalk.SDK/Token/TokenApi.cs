// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : TokenApi.cs
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
using System.Threading.Tasks;
using Magicodes.Dingtalk.SDK.Token.Dto;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Magicodes.Dingtalk.SDK.Token
{
    public class TokenApi : ApiBase
    {
        private readonly IConfiguration _configuration;

        public TokenApi(ILogger<TokenApi> logger, IConfiguration configuration, IServiceProvider serviceProvider) :
            base(logger, serviceProvider)
        {
            _configuration = configuration;
        }

        public async Task<GetTokenResult> GetToken()
        {
            var appKey = _configuration["Dingtalk:AppKey"];
            var appSecret = _configuration["Dingtalk:AppSecret"];
            return await Get<GetTokenResult>(
                $"gettoken?appkey={appKey}&appsecret={appSecret}");
        }
    }
}