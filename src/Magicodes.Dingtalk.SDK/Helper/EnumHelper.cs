// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : EnumHelper.cs
//           description :
//   
//           created by 雪雁 at  2019-03-13 10:05
//           Mail: wenqiang.li@xin-lai.com
//           QQ群：85318032（技术交流）
//           Blog：http://www.cnblogs.com/codelove/
//           GitHub：https://github.com/xin-lai
//           Home：http://xin-lai.com
//   
// ======================================================================

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Magicodes.Dingtalk.SDK.Helper
{
    /// <summary>
    ///     枚举帮助类
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        ///     从枚举中获取Description
        /// </summary>
        /// <param name="en">需要获取枚举描述的枚举</param>
        /// <returns>描述内容</returns>
        public static string GetDescription(this Enum en)
        {
            var _description = string.Empty;
            var _fieldInfo = en.GetType().GetField(en.ToString());
            var _attributes = _fieldInfo.GetDescriptAttr();
            if (_attributes != null && _attributes.Length > 0)
                _description = _attributes[0].Description;
            else
                _description = en.ToString();
            return _description;
        }


        /// <summary>
        ///     获取一个枚举类的字段Description
        /// </summary>
        /// <param name="fieldInfo">FieldInfo</param>
        /// <returns>DescriptionAttribute[] </returns>
        public static DescriptionAttribute[] GetDescriptAttr(this FieldInfo fieldInfo)
        {
            if (fieldInfo != null)
                return (DescriptionAttribute[]) fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return null;
        }

        /// <summary>
        ///     获取枚举的display
        /// </summary>
        /// <param name="en">枚举</param>
        /// <returns>返回枚举的描述</returns>
        public static string GetDisplay(this Enum en)
        {
            var type = en.GetType(); //获取类型  
            var memberInfos = type.GetMember(en.ToString()); //获取成员  
            if (memberInfos != null && memberInfos.Length > 0)
                if (memberInfos[0].GetCustomAttributes(typeof(DisplayAttribute), false) is DisplayAttribute[] attrs &&
                    attrs.Length > 0)
                    return attrs[0].Name ?? attrs[0].Description; //返回当前名称  
            return en.ToString();
        }
    }
}