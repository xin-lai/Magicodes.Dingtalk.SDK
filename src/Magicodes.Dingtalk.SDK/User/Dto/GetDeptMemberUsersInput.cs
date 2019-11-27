using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 获取部分用户userid列表
    /// </summary>
    public class GetDeptMemberUsersInput
    {
        /// <summary>
        /// 接口凭证 
        /// </summary>
        [JsonProperty("access_token")]
        public string Access_Token { get; set; }

        /// <summary>
        /// 通讯录语言(默认zh_CN另外支持en_US)
        /// </summary>
        [JsonProperty("lang")]
        public string Language { get; set; }

        /// <summary>
        /// 获取的部门id
        /// </summary>
        [JsonProperty("department_id")]
        public long Department_Id { get; set; }

        /// <summary>
        /// 支持分页查询，与size参数同时设置时才生效，此参数代表偏移量
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// 支持分页查询，与offset参数同时设置时才生效，此参数代表分页大小，最大100
        /// </summary>
        [JsonProperty("size")]
        public long? Size { get; set; }

        /// <summary>
        /// 支持分页查询，部门成员的排序规则，默认不传是按自定义排序；
        /// entry_asc：代表按照进入部门的时间升序，
        /// entry_desc：代表按照进入部门的时间降序，
        /// modify_asc：代表按照部门信息修改时间升序，
        /// modify_desc：代表按照部门信息修改时间降序，
        /// custom：代表用户定义(未定义时按照拼音)排序
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }
    }
}
