using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IPhotoReply
    {
        // ������Ƭ�ظ�
        int Save(PhotoReply pPhotoReplyFullInfo, ActionProvider pActionProvider);

        // ���һ����Ƭ�ظ�
        PhotoReply GetModel(PhotoReply pPhotoReplyFullInfo);

        // ��ȡ��Ƭ�ظ��б�
        List<PhotoReply> GetList(PhotoReply pPhotoReplyFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
