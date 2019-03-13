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
        ///     获取部门列表
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
    }
}