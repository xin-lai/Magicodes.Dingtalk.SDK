using Magicodes.Dingtalk.SDK.User.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.Dingtalk.SDK.User
{
    /// <summary>
    /// 员工API
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
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<CreateUserResult> Create(CreateOrEditUsersInput input)
        {
            return await Post<CreateUserResult>(
               "user/create", new
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
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResultBase> Update(CreateOrEditUsersInput input)
        {
            return await Post<ApiResultBase>(
               "user/update", new
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
        /// <param name="userid"></param>
        /// <returns></returns>
        public async Task<ApiResultBase> Delete(string userid)
        {
            return await Get<ApiResultBase>("user/delete?userid=" + userid);
        }

        /// <summary>
        /// 获取员工详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetUserDetailsResult> GetUserDetails(GetUserDetailsInput input)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "userid", input.UserId },
                { "lang", input.Language }
            };
            return await Get<GetUserDetailsResult>("user/get", dictionary);
        }

        /// <summary>
        /// 获取部门用户userid列表
        /// </summary>
        /// <param name="DeptId">部门id</param>
        /// <returns></returns>
        public async Task<GetUserDetailsResult> GetDeptMemberUserIds(string DeptId)
        {
            return await Get<GetUserDetailsResult>("user/getDeptMember?deptId=" + DeptId);
        }

        /// <summary>
        /// 获取部门用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetDeptMemberUsersResult> GetDeptMemberUsers(GetDeptMemberUsersInput input)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                {"department_id", input.DepartmentId.ToString()},
                { "lang", input.Language },
                { "order", input.Order }
            };
            if (input.Offset.HasValue && input.Size.HasValue)
            {
                dictionary.Add("offset", input.Offset?.ToString());
                dictionary.Add("size", input.Size?.ToString());
            }
            return await Get<GetDeptMemberUsersResult>("user/simplelist", dictionary);
        }

        /// <summary>
        /// 获取部门用户详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetDeptMemberUserDetailsResult> GetDeptMemberUserDetails(GetDeptMemberUserDetailsInput input)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "department_id", input.DepartmentId.ToString() },
                { "lang", input.Language },
                { "offset", input.Offset.ToString() },
                { "size", input.Size.ToString() },
                { "order", input.Order }
            };
            return await Get<GetDeptMemberUserDetailsResult>("user/listbypage", dictionary);
        }

        /// <summary>
        /// 获取管理员列表
        /// </summary>
        /// <returns></returns>
        public async Task<GetAdminsListResult> GetAdminsList()
        {
            return await Get<GetAdminsListResult>("user/get_admin");
        }

        /// <summary>
        /// 获取管理员通讯录权限范围
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public async Task<GetAdminScopeResult> GetAdminScope(string UserId)
        {
            return await Get<GetAdminScopeResult>("topapi/user/get_admin_scope?userid=" + UserId);
        }

        /// <summary>
        /// 根据unionid获取userid
        /// </summary>
        /// <param name="UnionId"></param>
        /// <returns></returns>
        public async Task<GetUserIdByUnionidResult> GetUserIdByUnionid(string UnionId)
        {
            return await Get<GetUserIdByUnionidResult>("getUseridByUnionid?unionid=xxx" + UnionId);
        }

        /// <summary>
        /// 根据手机号获取userid
        /// </summary>
        /// <param name="Mobile"></param>
        /// <returns></returns>
        public async Task<GetUserIdByMobileResult> GetUserIdByMobile(string Mobile)
        {
            return await Get<GetUserIdByMobileResult>("user/get_by_mobile?mobile=" + Mobile);
        }

        /// <summary>
        /// 获取企业员工人数
        /// </summary>
        /// <param name="OnlyActive"></param>
        /// <returns></returns>
        public async Task<GetOrgUserCountResult> GetOrgUserCount(int OnlyActive)
        {
            return await Get<GetOrgUserCountResult>("user/get_org_user_count?onlyActive=" + OnlyActive);
        }

        /// <summary>
        /// 未登录钉钉的员工列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetInactiveUsersListResult> GetInactiveUsersList(GetInactiveUsersListInput input)
        {
            return await Post<GetInactiveUsersListResult>("topapi/inactive/user/get", new
            {
                query_date = input.QueryDate,
                offset = input.Offset,
                size = input.Size
            });
        }
    }
}
