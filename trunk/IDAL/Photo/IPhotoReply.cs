using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IPhotoReply
    {
        // 保存照片回复
        int Save(PhotoReply pPhotoReplyFullInfo, ActionProvider pActionProvider);

        // 获得一条照片回复
        PhotoReply GetModel(PhotoReply pPhotoReplyFullInfo);

        // 获取照片回复列表
        List<PhotoReply> GetList(PhotoReply pPhotoReplyFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
