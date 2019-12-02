using Magicodes.Dingtalk.SDK.Auth.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Magicodes.Dingtalk.SDK.Auth
{
    /// <summary>
    /// 权限API
    /// </summary>
    public class AuthApi : ApiBase
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="serviceProvider"></param>
        public AuthApi(ILogger<AuthApi> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        /// <summary>
        /// 获取通讯录权限范围
        /// </summary>
        /// <returns></returns>
        public async Task<GetAuthScopesResult> GetAuthScopes()
        {
            return await Get<GetAuthScopesResult>("auth/scopes?access_token={ACCESS_TOKEN}");
        }
    }
}