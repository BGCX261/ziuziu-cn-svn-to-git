using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IPhoto
    {
        // 保存照片
        int Save(Photo pPhotoFullInfo, ActionProvider pActionProvider);

        // 获得一条照片信息
        Photo GetModel(Photo pPhotoFullInfo);

        // 获取照片信息列表
        List<Photo> GetList(Photo pPhotoFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
