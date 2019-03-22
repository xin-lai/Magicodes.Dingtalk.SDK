// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : ApiBase.cs
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

using Magicodes.Dingtalk.SDK.Token;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Magicodes.Dingtalk.SDK
{
    public abstract class ApiBase
    {
        private const string AccessTokenString = "{ACCESS_TOKEN}";
        private const string BaseApiUrl = "https://oapi.dingtalk.com/";
        protected readonly ILogger<ApiBase> _logger;
        private readonly IServiceProvider _serviceProvider;

        protected ApiBase(ILogger<ApiBase> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        protected virtual async Task<T> Get<T>(string resourceUrl, Dictionary<string, string> queryParameters = null) where T : ApiResultBase, new()
        {
            _logger.LogDebug($"GET {BaseApiUrl}{resourceUrl}");
            resourceUrl = await SetAccessToken(resourceUrl);
            var client = new RestClient(BaseApiUrl);
            var request = new RestRequest(resourceUrl, Method.GET);
            request.AddHeader("cache-control", "no-cache");
            if (queryParameters != null && queryParameters.Count > 0)
            {
                foreach (var par in queryParameters)
                {
                    request.AddQueryParameter(par.Key, par.Value, true);
                }
            }
            return await ReturnDataAsync<T>(client, request);
        }

        protected virtual async Task<T> Post<T>(string resourceUrl, object data = null) where T : ApiResultBase, new()
        {
            _logger.LogDebug(
                $"POST {BaseApiUrl}{resourceUrl}{(data != null ? Environment.NewLine + JsonConvert.SerializeObject(data) : string.Empty)}");

            resourceUrl = await SetAccessToken(resourceUrl);
            var client = new RestClient(BaseApiUrl);
            var request = new RestRequest(resourceUrl, Method.POST);
            request.AddHeader("cache-control", "no-cache");
            if (data != null)
            {
                request.AddJsonBody(data);
            }

            return await ReturnDataAsync<T>(client, request);
        }

        private async Task<string> SetAccessToken(string url)
        {
            if (url.IndexOf(AccessTokenString, StringComparison.CurrentCultureIgnoreCase) == -1)
            {
                return url;
            }

            var tokenManager = _serviceProvider.GetService<TokenManager>();
            var token = await tokenManager.GetToken();
            url = url.Replace(AccessTokenString, token, StringComparison.CurrentCultureIgnoreCase);
            _logger.LogDebug("Url Token 更新成功...");
            return url;
        }

        private async Task<T> ReturnDataAsync<T>(RestClient client, RestRequest request) where T : ApiResultBase, new()
        {
            var response = await client.ExecuteTaskAsync(request);
            _logger.LogDebug($"{response.StatusCode} {response.Content}");
            var data = JsonConvert.DeserializeObject<T>(response.Content);
            return data;
        }
    }
}