using Magicodes.Dingtalk.SDK.File.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.Dingtalk.SDK.File
{
    /// <summary>
    /// 
    /// </summary>
    public class FileApi : ApiBase
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name=""></param>
        /// <param name="logger"></param>
        /// <param name="serviceProvider"></param>
        public FileApi(ILogger<FileApi> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        /// <summary>
        /// 单步上传文件
        /// </summary>
        /// <param name="agentId">微应用的agentId</param>
        /// <param name="fileSize">文件大小</param>
        /// <returns></returns>
        public async Task<SingleUploadResult> SingleUpload(string agentId, int fileSize)
        {
            return await Post<SingleUploadResult>("file/upload/single?access_token={ACCESS_TOKEN}", new
            {
                agent_id = agentId,
                file_size = fileSize
            });
        }

        /// <summary>
        /// 开启分块上传事务
        /// </summary>
        /// <param name="agentId">微应用的agentId</param>
        /// <param name="fileSize">文件大小</param>
        /// <param name="chunkNumbers">文件总块数</param>
        /// <returns></returns>
        public async Task<TransactionUploadResult> TransactionUpload(string agentId, int fileSize, int chunkNumbers)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>()
            {
                { "agent_id",agentId},
                { "file_size",fileSize.ToString()},
                { "chunk_numbers",chunkNumbers.ToString()}
            };
            return await Get<TransactionUploadResult>("file/upload/transaction?access_token={ACCESS_TOKEN}", pairs);
        }

        /// <summary>
        /// 上传文件块
        /// </summary>
        /// <param name="agentId">微应用的agentId</param>
        /// <param name="uploadId">上传事务id，需要utf-8 urlEncode</param>
        /// <param name="chunkSequence">文件块号，从1开始计数</param>
        /// <returns></returns>
        public async Task<ApiResultBase> ChunkUpload(string agentId, string uploadId, int chunkSequence)
        {
            return await Post<ApiResultBase>("file/upload/chunk?access_token={ACCESS_TOKEN}", new
            {
                agent_id = agentId,
                upload_id = uploadId,
                chunk_sequence = chunkSequence
            });
        }

        /// <summary>
        /// 提交文件上传事务
        /// </summary>
        /// <param name="agentId">微应用的agentId</param>
        /// <param name="fileSize">文件大小</param>
        /// <param name="chunkNumbers">文件总块数</param>
        /// <param name="uploadId">上传事务id，需要utf-8 urlEncode</param>
        /// <returns></returns>
        public async Task<SingleUploadResult> TransactionUpload(string agentId, int fileSize, int chunkNumbers, string uploadId)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>()
            {
                { "agent_id",agentId},
                { "file_size",fileSize.ToString()},
                { "chunk_numbers",chunkNumbers.ToString()},
                { "upload_id",uploadId}
            };
            return await Get<SingleUploadResult>("file/upload/transaction?access_token={ACCESS_TOKEN}", pairs);
        }
    }
}
