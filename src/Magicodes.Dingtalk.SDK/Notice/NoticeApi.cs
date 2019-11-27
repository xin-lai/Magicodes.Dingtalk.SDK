// ======================================================================
//   
//           Copyright (C) 2019-2020 湖南心莱信息科技有限公司    
//           All rights reserved
//   
//           filename : NoticeApi.cs
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

using System;
using System.Threading.Tasks;
using Magicodes.Dingtalk.SDK.Helper;
using Magicodes.Dingtalk.SDK.Notice.Dto;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Magicodes.Dingtalk.SDK.Notice
{
    public class NoticeApi : ApiBase
    {
        public NoticeApi(ILogger<NoticeApi> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
        }

        /// <summary>
        ///     发送工作通知消息
        ///     同一个微应用相同消息的内容同一个用户一天只能接收一次。
        ///     同一个微应用给同一个用户发送消息，如果是ISV应用开发方式一天不得超过50次；如果是企业内部开发方式，此上限为500次。
        ///     该接口是异步发送消息，接口返回成功并不表示用户一定会收到消息，需要通过“查询工作通知消息的发送结果”接口查询是否给用户发送成功。
        /// </summary>
        /// <returns></returns>
        public async Task<NoticeJobResult> JobNotice(int agentId, string useridList, MsgHelper msg)
        {
            return await Post<NoticeJobResult>(
                "topapi/message/corpconversation/asyncsend_v2?access_token={ACCESS_TOKEN}", new
                {
                    agentId,
                    useridList,
                    msg = JsonConvert.SerializeObject(msg)
                });
        }
    }
}