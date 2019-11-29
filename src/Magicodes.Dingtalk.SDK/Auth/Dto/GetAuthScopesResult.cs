using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Auth.Dto
{
    /// <summary>
    /// 获取通讯录权限范围返回结果
    /// </summary>
    public class GetAuthScopesResult : ApiResultBase
    {
        /// <summary>
        /// 可以得到的企业用户字段
        /// </summary>
        [JsonProperty("auth_user_field")]
        public string[] AuthUserField { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("auth_org_scopes")]
        public authOrg AuthOrgScopes { get; set; }
    }

    /// <summary>
    ///
    /// </summary>
    public class authOrg
    {
        /// <summary>
        /// 企业授权的部门id列表
        /// </summary>
        [JsonProperty("authed_dept")]
        public int[] AuthedDept { get; set; }

        /// <summary>
        /// 企业授权的员工userid列表
        /// </summary>
        [JsonProperty("authed_user")]
        public string[] AuthedUser { get; set; }
    }
}