using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;


namespace Ziuziu.IDAL
{
    public interface IArea
    {
        // �������
        int Save(Area pAreaFullInfo, ActionProvider pActionProvider);

        // ���һ��������Ϣ
        Area GetModel(Area pAreaFullInfo);

        // ��ȡ������Ϣ�б�
        List<Area> GetList(Area pAreaFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
