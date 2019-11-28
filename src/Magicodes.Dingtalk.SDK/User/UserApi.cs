using Magicodes.Dingtalk.SDK.User.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.Dingtalk.SDK.User
{
    /// <summary>
    /// 用户管理API
    /// </summary>
    public class UserApi : ApiBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <param name="logger"></param>
        /// <param name="serviceProvider"></param>
        public UserApi(ILogger<UserApi> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        /// <summary>
        /// 创建员工
        /// </summary>
        /// <param name="input">创建员工</param>
        /// <returns></returns>
        public async Task<CreateUserResult> Create(CreateOrEditUsersInput input)
        {
            return await Post<CreateUserResult>(
               "user/create?access_token={ACCESS_TOKEN}", new
               {
                   userid = input.UserId,
                   name = input.Name,
                   orderInDepts = input.OrderInDepts,
                   department = input.Department,
                   position = input.Position,
                   mobile = input.Mobile,
                   tel = input.Tel,
                   workPlace = input.WorkPlace,
                   remark = input.Remark,
                   email = input.Email,
                   orgEmail = input.OrgEmail,
                   jobnumber = input.Jobnumber,
                   isHide = input.isHide,
                   isSenior = input.isSenior,
                   extattr = input.Extattr
               });
        }

        /// <summary>
        /// 更新员工
        /// </summary>
        /// <param name="input">更新员工</param>
        /// <returns></returns>
        public async Task<ApiResultBase> Update(CreateOrEditUsersInput input)
        {
            return await Post<ApiResultBase>(
               "user/update?access_token={ACCESS_TOKEN}", new
               {
                   userid = input.UserId,
                   name = input.Name,
                   orderInDepts = input.OrderInDepts,
                   department = input.Department,
                   position = input.Position,
                   tel = input.Tel,
                   workPlace = input.WorkPlace,
                   remark = input.Remark,
                   email = input.Email,
                   orgEmail = input.OrgEmail,
                   jobnumber = input.Jobnumber,
                   isHide = input.isHide,
                   isSenior = input.isSenior,
                   extattr = input.Extattr
               });
        }

        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="userid">员工id</param>
        /// <returns></returns>
        public async Task<ApiResultBase> Delete(string userid)
        {
            return await Get<ApiResultBase>("user/delete?access_token={ACCESS_TOKEN}&userid=" + userid);
        }

        /// <summary>
        /// 获取员工详情
        /// </summary>
        /// <param name="userId">员工id</param>
        /// <param name="lang">通讯录语言</param>
        /// <returns></returns>
        public async Task<GetUserDetailsResult> GetUserDetails(string userId, string lang = "zh_CN")
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "userid", userId },
                { "lang", lang }
            };
            return await Get<GetUserDetailsResult>("user/get?access_token={ACCESS_TOKEN}", queryParameters);
        }

        /// <summary>
        /// 获取部门用户userid列表
        /// </summary>
        /// <param name="deptId">部门id</param>
        /// <returns></returns>
        public async Task<GetUserDetailsResult> GetDeptMemberUserIds(string deptId)
        {
            return await Get<GetUserDetailsResult>("user/getDeptMember?access_token={ACCESS_TOKEN}&deptId=" + deptId);
        }

        /// <summary>
        /// 获取部门用户
        /// </summary>
        /// <param name="input">获取部门用户</param>
        /// <returns></returns>
        public async Task<GetDeptMemberUsersResult> GetDeptMemberUsers(GetDeptMemberUsersInput input)
        {
            var queryParameters = new Dictionary<string, string>
            {
                {"department_id", input.DepartmentId.ToString()},
                { "lang", input.Language },
                { "order", input.Order }
            };
            if (input.Offset.HasValue && input.Size.HasValue)
            {
                queryParameters.Add("offset", input.Offset?.ToString());
                queryParameters.Add("size", input.Size?.ToString());
            }
            return await Get<GetDeptMemberUsersResult>("user/simplelist?access_token={ACCESS_TOKEN}", queryParameters);
        }

        /// <summary>
        /// 获取部门用户详情
        /// </summary>
        /// <param name="input">获取部门用户详情</param>
        /// <returns></returns>
        public async Task<GetDeptMemberUserDetailsResult> GetDeptMemberUserDetails(GetDeptMemberUserDetailsInput input)
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "department_id", input.DepartmentId.ToString() },
                { "lang", input.Language },
                { "offset", input.Offset.ToString() },
                { "size", input.Size.ToString() },
                { "order", input.Order }
            };
            return await Get<GetDeptMemberUserDetailsResult>("user/listbypage", queryParameters);
        }

        /// <summary>
        /// 获取管理员列表
        /// </summary>
        /// <returns></returns>
        public async Task<GetAdminsListResult> GetAdminsList()
        {
            return await Get<GetAdminsListResult>("user/get_admin?access_token={ACCESS_TOKEN}");
        }

        /// <summary>
        /// 获取管理员通讯录权限范围
        /// </summary>
        /// <param name="userId">员工id</param>
        /// <returns></returns>
        public async Task<GetAdminScopeResult> GetAdminScope(string userId)
        {
            return await Get<GetAdminScopeResult>("topapi/user/get_admin_scope?access_token={ACCESS_TOKEN}&userid=" + userId);
        }

        /// <summary>
        /// 根据unionid获取userid
        /// </summary>
        /// <param name="unionId">员工在当前开发者企业账号范围内的唯一标识，系统生成，固定值，不会改变</param>
        /// <returns></returns>
        public async Task<GetUserIdByUnionidResult> GetUserIdByUnionid(string unionId)
        {
            return await Get<GetUserIdByUnionidResult>("getUseridByUnionid?access_token={ACCESS_TOKEN}&unionid=xxx" + unionId);
        }

        /// <summary>
        /// 根据手机号获取userid
        /// </summary>
        /// <param name="mobile">手机号码</param>
        /// <returns></returns>
        public async Task<GetUserIdByMobileResult> GetUserIdByMobile(string mobile)
        {
            return await Get<GetUserIdByMobileResult>("user/get_by_mobile?access_token={ACCESS_TOKEN}&mobile=" + mobile);
        }

        /// <summary>
        /// 获取企业员工人数
        /// </summary>
        /// <param name="onlyActive">0：包含未激活钉钉的人员数量,1：不包含未激活钉钉的人员数量</param>
        /// <returns></returns>
        public async Task<GetOrgUserCountResult> GetOrgUserCount(int onlyActive)
        {
            return await Get<GetOrgUserCountResult>("user/get_org_user_count?access_token={ACCESS_TOKEN}&onlyActive=" + onlyActive);
        }

        /// <summary>
        /// 未登录钉钉的员工列表
        /// </summary>
        /// <param name="input">未登录钉钉的员工列表</param>
        /// <returns></returns>
        public async Task<GetInactiveUsersListResult> GetInactiveUsersList(GetInactiveUsersListInput input)
        {
            return await Post<GetInactiveUsersListResult>("topapi/inactive/user/get?access_token={ACCESS_TOKEN}", new
            {
                query_date = input.QueryDate,
                offset = input.Offset,
                size = input.Size
            });
        }
    }
}
