// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : DailyApi.cs
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
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResultBase> Create(CreateOrEditUsersInput input)
        {
            // TODO:判断员工id，手机号码，分机号，邮箱 ，是否重复
            return await Post<ApiResultBase>(
               "user/create?access_token=ACCESS_TOKEN", new
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
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResultBase> Update(CreateOrEditUsersInput input)
        {
            // TODO:判断员工id，手机号码，分机号，邮箱 ，是否重复
            return await Post<ApiResultBase>(
               "user/update?access_token=ACCESS_TOKEN", new
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
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public async Task<ApiResultBase> Delete(string userid)
        {
            return await Get<ApiResultBase>("user/delete?access_token=ACCESS_TOKEN&userid=" + userid);
        }
    }
}
