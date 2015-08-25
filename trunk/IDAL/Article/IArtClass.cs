using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IArtClass
    {
        // 保存信息类别
        int Save(ArtClass pArtClassFullInfo, ActionProvider pActionProvider);

        // 获得一条信息类别
        ArtClass GetModel(ArtClass pArtClassFullInfo);

        // 获取地区信息类别
        List<ArtClass> GetList(ArtClass pArtClassFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
