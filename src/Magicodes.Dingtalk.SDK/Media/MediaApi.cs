using Magicodes.Dingtalk.SDK.Media.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.Dingtalk.SDK.Media
{
    /// <summary>
    /// 媒体
    /// </summary>
    public class MediaApi : ApiBase
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name=""></param>
        /// <param name="logger"></param>
        /// <param name="serviceProvider"></param>
        public MediaApi(ILogger<MediaApi> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        /// <summary>
        /// 上传媒体文件
        /// </summary>
        /// <param name="type">媒体文件类型，分别有图片（image）、语音（voice）、普通文件(file)</param>
        /// <param name="media">form-data中媒体文件标识，有filename、filelength、content-type等信息</param>
        /// <returns></returns>
        public async Task<UploadResult> Upload(string type,string media)
        {
            return await Post<UploadResult>("media/upload?access_token={ACCESS_TOKEN}", new
            {
                type = type,
                media = media
            });
        }
    }
}
