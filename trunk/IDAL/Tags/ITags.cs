using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface ITags
    {
        // 保存标签
        int Save(Tags pTagsFullInfo, ActionProvider pActionProvider);

        // 获得一条标签信息
        Tags GetModel(Tags pTagsFullInfo);

        // 获取标签信息列表
        List<Tags> GetList(Tags pTagsFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
