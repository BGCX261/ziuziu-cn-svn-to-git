using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IPhoto
    {
        // ������Ƭ
        int Save(Photo pPhotoFullInfo, ActionProvider pActionProvider);

        // ���һ����Ƭ��Ϣ
        Photo GetModel(Photo pPhotoFullInfo);

        // ��ȡ��Ƭ��Ϣ�б�
        List<Photo> GetList(Photo pPhotoFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
