using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IAlbum
    {
        // 保存相册
        int Save(Album pAlbumFullInfo, ActionProvider pActionProvider);

        // 获得一条相册信息
        Album GetModel(Album pAlbumFullInfo);

        // 获取相册信息列表
        List<Album> GetList(Album pAlbumFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
