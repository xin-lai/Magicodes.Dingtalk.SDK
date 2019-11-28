// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : DepartmentApi.cs
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

using Magicodes.Dingtalk.SDK.Department.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Magicodes.Dingtalk.SDK.Department
{
    public class DepartmentApi : ApiBase
    {
        public DepartmentApi(ILogger<DepartmentApi> logger, IServiceProvider serviceProvider) : base(logger,
            serviceProvider)
        {
        }

        /// <summary>
        /// 获取部门列表
        /// </summary>
        /// <param name="lang"></param>
        /// <param name="fetchChild">是否递归部门的全部子部门，ISV微应用固定传递false</param>
        /// <param name="id">父部门id（如果不传，默认部门为根部门，根部门ID为1）</param>
        /// <returns></returns>
        public async Task<DepartmentResult> DepartmentList(string lang = "zh_CN", bool fetchChild = true,
            string id = null)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                {"lang","zh_CN" },
                {"fetch_child",fetchChild.ToString()}
            };
            if (id != null)
            {
                queryParameters.Add("id", id);
            }

            return await Get<DepartmentResult>("department/list?access_token={ACCESS_TOKEN}", queryParameters);
        }

        /// <summary>
        /// 创建部门
        /// </summary>
        /// <param name="input">创建部门</param>
        /// <returns></returns>
        public async Task<CreateOrUpdateDepartmentResult> Create(CreateDepartmentInput input)
        {
            return await Post<CreateOrUpdateDepartmentResult>("department/create?access_token={ACCESS_TOKEN}", new
            {
                name = input.Name,
                parentid = input.ParentId,
                order = input.Order,
                createDeptGroup = input.CreateDeptGroup,
                deptHiding = input.DeptHiding,
                deptPermits = input.DeptPermits,
                userPermits = input.UserPermits,
                outerDept = input.OuterDept,
                outerPermitDepts = input.OuterPermitDepts,
                outerPermitUsers = input.OuterPermitUsers,
                outerDeptOnlySelf = input.OuterDeptOnlySelf,
                sourceIdentifier = input.SourceIdentifier
            });
        }

        /// <summary>
        /// 更新部门
        /// </summary>
        /// <param name="input">更新部门</param>
        /// <returns></returns>
        public async Task<CreateOrUpdateDepartmentResult> Update(UpdateDepartmentInput input)
        {
            return await Post<CreateOrUpdateDepartmentResult>("department/update?access_token={ACCESS_TOKEN}", new
            {
                lang = input.Lang,
                name = input.Name,
                parentid = input.ParentId,
                order = input.Order,
                id = input.Id,
                createDeptGroup = input.CreateDeptGroup,
                groupContainSubDept = input.GroupContainSubDept,
                groupContainOuterDept = input.GroupContainOuterDept,
                groupContainHiddenDept = input.GroupContainHiddenDept,
                autoAddUser = input.AutoAddUser,
                deptManagerUseridList = input.DeptManagerUseridList,
                deptHiding = input.DeptHiding,
                deptPermits = input.DeptPermits,
                userPermits = input.UserPermits,
                outerDept = input.OuterDept,
                outerPermitDepts = input.OuterPermitDepts,
                outerPermitUsers = input.OuterPermitUsers,
                outerDeptOnlySelf = input.OuterDeptOnlySelf,
                orgDeptOwner = input.OrgDeptOwner,
                sourceIdentifier = input.SourceIdentifier
            });
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="id">部门id (注：不能删除根部门；当部门里有员工，或者部门的子部门里有员工，也不能删除)</param>
        /// <returns></returns>
        public async Task<ApiResultBase> Delete(string id)
        {
            return await Get<ApiResultBase>("department/delete?access_token={ACCESS_TOKEN&}id=" + id);
        }

        /// <summary>
        /// 获取子部门ID列表
        /// </summary>
        /// <param name="id">父部门id。根部门的话传1</param>
        /// <returns></returns>
        public async Task<GetDepartmentParentsListByDeptIdResult> GetSubDepartmentListIds(string id)
        {
            return await Get<GetDepartmentParentsListByDeptIdResult>("department/list_ids?access_token={ACCESS_TOKEN}&id=" + id);
        }

        /// <summary>
        /// 获取部门详情
        /// </summary>
        /// <param name="id">部门id</param>
        /// <param name="lang">通讯录语言(默认zh_CN，未来会支持en_US)</param>
        /// <returns></returns>
        public async Task<GetDepartmentDetailsResult> GetDepartmentDetails(string id,string lang = "zh_CN")
        {
            return await Get<GetDepartmentDetailsResult>("department/get?access_token={ACCESS_TOKEN}&id=" + id);
        }

        /// <summary>
        /// 查询部门的所有上级父部门路径
        /// </summary>
        /// <param name="id">希望查询的部门的id，包含查询的部门本身</param>
        /// <returns></returns>
        public async Task<GetDepartmentParentsListByDeptIdResult> GetDepartmentParentsListByDeptId(string id)
        {
            return await Get<GetDepartmentParentsListByDeptIdResult>("department/list_parent_depts_by_dept?access_token={ACCESS_TOKEN}&id=" + id);
        }

        /// <summary>
        /// 查询指定用户的所有上级父部门路径
        /// </summary>
        /// <param name="userId">希望查询的用户的id</param>
        /// <returns></returns>
        public async Task<GetDepartmentParentsListByUserIdResult> GetDepartmentParentsListByUserId(string userId)
        {
            return await Get<GetDepartmentParentsListByUserIdResult>("department/list_parent_depts?access_token={ACCESS_TOKEN}&userId=" + userId);
        }
    }
}