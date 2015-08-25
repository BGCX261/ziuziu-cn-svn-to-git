using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IPath
    {
        // 保存足迹
        int Save(Path pPathFullInfo, ActionProvider pActionProvider);

        // 获得一条足迹信息
        Path GetModel(Path pPathFullInfo);

        // 获取足迹信息列表
        List<Path> GetList(Path pPathFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
