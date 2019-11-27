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
            // 把入职时间转换为时间戳
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
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResultBase> Update(CreateOrEditUsersInput input)
        {
            // TODO:判断员工id，手机号码，分机号，邮箱 ，是否重复
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
        /// <param name="userid"></param>
        /// <returns></returns>
        public async Task<ApiResultBase> Delete(string userid)
        {
            return await Get<ApiResultBase>("user/delete?access_token={ACCESS_TOKEN}&userid=" + userid);
        }

        /// <summary>
        /// 获取员工详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetUserDetailsResult> GetUserDetails(GetUserDetailsInput input)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("lang", input.Language);
            return await Get<GetUserDetailsResult>("user/get?access_token={ACCESS_TOKEN}&userid=" + input.UserId, dictionary);
        }

        /// <summary>
        /// 获取部门用户userid列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetUserDetailsResult> GetDeptMemberUserIds(GetDeptMemberUserIdsInput input)
        {
            return await Get<GetUserDetailsResult>("user/getDeptMember?access_token={ACCESS_TOKEN}&deptId=" + input.DeptId);
        }

        /// <summary>
        /// 获取部门用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetDeptMemberUsersResult> GetDeptMemberUsers(GetDeptMemberUsersInput input)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("lang", input.Language);
            dictionary.Add("offset", input.Offset.ToString());
            dictionary.Add("size", input.Size.ToString());
            dictionary.Add("order", input.Order);
            return await Get<GetDeptMemberUsersResult>("user/simplelist?access_token={ACCESS_TOKEN}&department_id=" + input.Department_Id, dictionary);
        }
    }
}
