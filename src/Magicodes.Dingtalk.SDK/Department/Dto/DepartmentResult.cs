// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : DepartmentResult.cs
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

using System.Collections.Generic;

namespace Magicodes.Dingtalk.SDK.Department.Dto
{
    /// <summary>
    ///     部门列表
    /// </summary>
    public class DepartmentResult : ApiResultBase
    {
        /// <summary>
        ///     部门列表数据，以部门的order字段从小到大排列
        /// </summary>
        public List<Departments> department { get; set; }
    }
}