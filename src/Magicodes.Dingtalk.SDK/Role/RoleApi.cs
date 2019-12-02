using Magicodes.Dingtalk.SDK.Role.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Magicodes.Dingtalk.SDK.Role
{
    /// <summary>
    /// 角色管理API
    /// </summary>
    public class RoleApi : ApiBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <param name="logger"></param>
        /// <param name="serviceProvider"></param>
        public RoleApi(ILogger<RoleApi> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="size">分页大小，默认值：20，最大值200</param>
        /// <param name="offset">分页偏移，默认值：0</param>
        /// <returns></returns>
        public async Task<GetRolesListResult> GetRolesList(int? size = 20, int? offset = 0)
        {
            return await Post<GetRolesListResult>("topapi/role/list?access_token={ACCESS_TOKEN}", new
            {
                size = size,
                offset = offset
            });
        }

        /// <summary>
        /// 获取角色下的员工列表
        /// </summary>
        /// <param name="roleId">角色ID</param>
        /// <param name="size">分页大小，默认值：20，最大值200</param>
        /// <param name="offset">分页偏移，默认值：0</param>
        /// <returns></returns>
        public async Task<GetRoleUsersListResult> GetRoleUsersList(int roleId, int? size = 20, int? offset = 0)
        {
            return await Post<GetRoleUsersListResult>("topapi/role/simplelist?access_token={ACCESS_TOKEN}", new
            {
                role_id = roleId,
                size = size,
                offset = offset
            });
        }

        /// <summary>
        /// 获取角色组
        /// </summary>
        /// <param name="groupId">角色组的Id</param>
        /// <returns></returns>
        public async Task<GetRoleGroupResult> GetRoleGroup(int groupId)
        {
            return await Post<GetRoleGroupResult>("topapi/role/getrolegroup?access_token={ACCESS_TOKEN}", new
            {
                group_id = groupId
            });
        }

        /// <summary>
        /// 获取角色详情
        /// </summary>
        /// <param name="roleId">角色Id</param>
        /// <returns></returns>
        public async Task<GetRoleDetailsResult> GetRoleDetails(int roleId)
        {
            return await Post<GetRoleDetailsResult>("topapi/role/getrole?access_token={ACCESS_TOKEN}", new
            {
                roleId = roleId
            });
        }

        /// <summary>
        /// 创建角色
        /// </summary>
        /// <param name="roleName">	角色名称</param>
        /// <param name="groupId">角色组id</param>
        /// <returns></returns>
        public async Task<CreateRoleResult> Create(string roleName, int groupId)
        {
            return await Post<CreateRoleResult>("role/add_role?access_token={ACCESS_TOKEN}", new
            {
                roleName = roleName,
                groupId = groupId
            });
        }

        /// <summary>
        /// 更新角色
        /// </summary>
        /// <param name="roleName">角色名称</param>
        /// <param name="roleId">角色id</param>
        /// <returns></returns>
        public async Task<ApiResultBase> Update(string roleName, int roleId)
        {
            return await Post<ApiResultBase>("role/update_role?access_token={ACCESS_TOKEN}", new
            {
                roleName = roleName,
                roleId = roleId
            });
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="roleId">角色id</param>
        /// <returns></returns>
        public async Task<ApiResultBase> Delete(int roleId)
        {
            return await Post<ApiResultBase>("topapi/role/deleterole?access_token={ACCESS_TOKEN}", new
            {
                role_id = roleId
            });
        }

        /// <summary>
        /// 创建角色组
        /// </summary>
        /// <param name="name">角色组名称</param>
        /// <returns></returns>
        public async Task<CreateRoleGroupResult> CreateRoleGroup(string name)
        {
            return await Post<CreateRoleGroupResult>("role/add_role_group?access_token={ACCESS_TOKEN}", new
            {
                name = name
            });
        }

        /// <summary>
        /// 批量增加员工角色
        /// </summary>
        /// <param name="roleIds">角色id list，最大列表长度：20</param>
        /// <param name="userIds">员工id list，最大列表长度：100</param>
        /// <returns></returns>
        public async Task<ApiResultBase> CreateBatchRolesUsers(List<string> roleIds, List<string> userIds)
        {
            // TODO:暂且没有判断list列表长度
            return await Post<ApiResultBase>("topapi/role/addrolesforemps?access_token={ACCESS_TOKEN}", new
            {
                roleIds = roleIds,
                userIds = userIds
            });
        }

        /// <summary>
        /// 批量删除员工角色
        /// </summary>
        /// <param name="roleIds">角色标签id，最大列表长度：20</param>
        /// <param name="userIds">用户userId，最大列表长度：100</param>
        /// <returns></returns>
        public async Task<ApiResultBase> DeleteBatchRolesUsers(List<string> roleIds, List<string> userIds)
        {
            return await Post<ApiResultBase>("topapi/role/removerolesforemps?access_token={ACCESS_TOKEN}", new
            {
                roleIds = roleIds,
                userIds = userIds
            });
        }

        /// <summary>
        /// 设定角色成员管理范围
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="roleId">角色id，必须是用户已经加入的角色</param>
        /// <param name="deptIds">部门id列表，最多50个，不传则设置范围为默认值：所有人</param>
        /// <returns></returns>
        public async Task<ApiResultBase> SetRoleUserScope(string userId,int roleId,int?[] deptIds)
        {
            return await Post<ApiResultBase>("topapi/role/scope/update?access_token={ACCESS_TOKEN}", new
            {
                userid = userId,
                role_id = roleId,
                dept_ids = deptIds
            });
        }
    }
}
