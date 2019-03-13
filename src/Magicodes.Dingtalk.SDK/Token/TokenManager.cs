// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : TokenManager.cs
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
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;

namespace Magicodes.Dingtalk.SDK.Token
{
    public class TokenManager
    {
        private const string Key = "DingtalkAccessToken";
        private readonly IDistributedCache _cache;
        private readonly ILogger<TokenManager> _logger;
        private readonly TokenApi _tokenApi;

        public TokenManager(IDistributedCache cache, TokenApi tokenApi, ILogger<TokenManager> logger)
        {
            _cache = cache;
            _tokenApi = tokenApi;
            _logger = logger;
        }

        public async Task<string> GetToken()
        {
            var value = await _cache.GetStringAsync(Key);
            if (!string.IsNullOrEmpty(value)) return value;
            var result = await _tokenApi.GetToken();
            value = result.AccessToken;
            _logger.LogDebug("Token获取成功...");
            await _cache.SetStringAsync(Key, value,
                new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(7000)));
            _logger.LogDebug("Token已写入缓存...");
            return value;
        }
    }
}