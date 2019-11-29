using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.User.Dto
{
    /// <summary>
    /// 分页Input
    /// </summary>
    public class PageInputBase
    {
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