using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IMessage
    {
        // 保存站内信息
        int Save(Message pMessageFullInfo, ActionProvider pActionProvider);

        // 获得一条站内信息
        Message GetModel(Message pMessageFullInfo);

        // 获取站内信息列表
        List<Message> GetList(Message pMessageFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
