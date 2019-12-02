using Magicodes.Dingtalk.SDK.Cspace.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Magicodes.Dingtalk.SDK.Cspace
{
    public class CspaceApi : ApiBase
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name=""></param>
        /// <param name="logger"></param>
        /// <param name="serviceProvider"></param>
        public CspaceApi(ILogger<CspaceApi> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        /// <summary>
        /// 发送钉盘文件给指定用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResultBase> AddToSingleChat(AddToSingleChatInput input)
        {
            return await Post<ApiResultBase>("cspace/add_to_single_chat?access_token={ACCESS_TOKEN}", new
            {
                agent_id = input.AgentId,
                userid = input.UserId,
                media_id = input.MediaId,
                file_name = input.FileName
            });
        }

        /// <summary>
        /// 新增文件到用户自定义空间
        /// </summary>
        /// <param name="input">新增文件到用户自定义空间</param>
        /// <returns></returns>
        public async Task<AddResult> Add(AddInput input)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>
            {
                { "agent_id", input.AgentId },
                { "code", input.Code },
                { "media_id", input.MediaId },
                { "space_id", input.SpaceId },
                { "folder_id", input.FolderId },
                { "name", input.Name },
                { "path", input.Path }
            };
            if (input.Overwrite.HasValue)
            {
                pairs.Add("overwrite", input.Overwrite.ToString());
            }
            return await Get<AddResult>("cspace/add?access_token={ACCESS_TOKEN}", pairs);
        }

        /// <summary>
        /// 获取企业下的自定义空间
        /// </summary>
        /// <param name="domain">企业内部调用时传入，需要为10个字节以内的字符串，仅可包含字母和数字，大小写不敏感</param>
        /// <param name="agentId">ISV调用时传入，微应用的agentId</param>
        /// <returns></returns>
        public async Task<GetCustomSpaceResult> GetCustomSpace(string domain, string agentId)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>()
            {
                {"domain",domain },
                {"agent_id",agentId }
            };
            return await Get<GetCustomSpaceResult>("cspace/get_custom_space?access_token={ACCESS_TOKEN}", pairs);
        }

        /// <summary>
        /// 获取应用自定义空间使用详情
        /// </summary>
        /// <param name="domain">企业内部调用时传入，需要为10个字节以内的字符串，仅可包含字母和数字，大小写不敏感</param>
        /// <param name="agentId">ISV调用时传入，微应用的agentId</param>
        /// <returns></returns>
        public async Task<UesdInfoResult> UesdInfo(string domain, string agentId)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>()
            {
                {"domain",domain },
                {"agent_id",agentId }
            };
            return await Get<UesdInfoResult>("cspace/uesd_info?access_token={ACCESS_TOKEN}", pairs);
        }

        /// <summary>
        /// 授权用户访问企业自定义空间
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResultBase> GrantCustomSpace(GrantCustomSpaceInput input)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>()
            {
                {"agent_id",input.AgentId },
                {"domain",input.Domain },
                {"type",input.Type },
                {"userid",input.UserId },
                {"path",input.Path },
                {"fileids",input.Fileids },
                {"duration",input.Domain }
            };
            return await Get<UesdInfoResult>("cspace/grant_custom_space?access_token={ACCESS_TOKEN}", pairs);
        }
    }
}