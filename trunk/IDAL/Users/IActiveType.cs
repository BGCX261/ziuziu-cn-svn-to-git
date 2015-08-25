using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IActiveType
    {
        // 保存会员活动状态类型
        int Save(ActiveType pActiveTypeFullInfo, ActionProvider pActionProvider);

        // 获得一条会员活动状态类型
        ActiveType GetModel(ActiveType pActiveTypeFullInfo);

        // 获取会员活动状态类型列表
        List<ActiveType> GetList(ActiveType pActiveTypeFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
