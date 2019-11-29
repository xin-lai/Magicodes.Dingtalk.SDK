using Magicodes.Dingtalk.SDK.Extcontact.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.Dingtalk.SDK.Extcontact
{
    /// <summary>
    /// 外部管理员联系API
    /// </summary>
    public class ExtcontactApi : ApiBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="serviceProvider"></param>
        public ExtcontactApi(ILogger<ExtcontactApi> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        /// <summary>
        /// 获取外部联系人标签列表
        /// </summary>
        /// <param name="size">分页大小，最大100</param>
        /// <param name="offset">偏移位置</param>
        /// <returns></returns>
        public async Task<GetExtcontactsListLableGroupsResult> GetExtcontactsListLableGroups(int size,int offset)
        {
            return await Post<GetExtcontactsListLableGroupsResult>("topapi/extcontact/listlabelgroups?access_token={ACCESS_TOKEN}", new
            {
                size = size,
                offset = offset
            });
        }

        /// <summary>
        /// 获取外部联系人列表
        /// </summary>
        /// <param name="size">分页大小，最大100</param>
        /// <param name="offset">偏移位置</param>
        /// <returns></returns>
        public async Task<GetExtcontactsListResult> GetExtcontactsList(int size, int offset)
        {
            return await Post<GetExtcontactsListResult>("topapi/extcontact/list?access_token={ACCESS_TOKEN}", new {
                size = size,
                offset = offset
            });
        }

        /// <summary>
        /// 获取外部联系人详情
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        public async Task<GetExtcontactDetailsResult> GetExtcontactDetails(string userId)
        {
            return await Post<GetExtcontactDetailsResult>("topapi/extcontact/get?access_token={ACCESS_TOKEN}", new
            {
                user_id = userId
            });
        }

        /// <summary>
        /// 添加外部联系人
        /// </summary>
        /// <param name="input">外部联系人</param>
        /// <returns></returns>
        public async Task<CreateExtcontactResult> Create(Extcontacts input)
        {
            return await Post<CreateExtcontactResult>("topapi/extcontact/create?access_token={ACCESS_TOKEN}", new
            {
                title = input.Title,
                label_ids = input.LabelIds,
                share_dept_ids = input.ShareDeptIds,
                address = input.Address,
                remark = input.Remark,
                follower_user_id = input.FollowerUserId,
                name = input.Name,
                state_code = input.StateCode,
                company_name = input.CompanyName,
                share_user_ids = input.ShareUserIds,
                mobile = input.Mobile
            });
        }

        /// <summary>
        /// 更新外部联系人
        /// </summary>
        /// <param name="input">外部联系人</param>
        /// <returns></returns>
        public async Task<ApiResultBase> Update(Extcontacts input)
        {
            return await Post<ApiResultBase>("topapi/extcontact/update?access_token={ACCESS_TOKEN}", new
            {
                user_id = input.UserId,
                title = input.Title,
                label_ids = input.LabelIds,
                share_dept_ids = input.ShareDeptIds,
                address = input.Address,
                remark = input.Remark,
                follower_user_id = input.FollowerUserId,
                name = input.Name,
                company_name = input.CompanyName,
                share_user_ids = input.ShareUserIds,
            });
        }

        /// <summary>
        /// 删除外部联系人
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        public async Task<ApiResultBase> Delete(string userId)
        {
            return await Post<ApiResultBase>("topapi/extcontact/delete?access_token={ACCESS_TOKEN}", new
            {
                user_id = userId
            });
        }
    }
}
