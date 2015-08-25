using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;


namespace Ziuziu.IDAL
{
    public interface IArea
    {
        // 保存地区
        int Save(Area pAreaFullInfo, ActionProvider pActionProvider);

        // 获得一条地区信息
        Area GetModel(Area pAreaFullInfo);

        // 获取地区信息列表
        List<Area> GetList(Area pAreaFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
