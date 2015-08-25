using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IRecentActive
    {
        // 保存最近会员活动状态
        int Save(RecentActive pRecentActiveFullInfo, ActionProvider pActionProvider);

        // 获得一条地区信息
        RecentActive GetModel(RecentActive pRecentActiveFullInfo);

        // 获取地区信息列表
        List<RecentActive> GetList(RecentActive pRecentActiveFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
