using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IRecentActive
    {
        // ���������Ա�״̬
        int Save(RecentActive pRecentActiveFullInfo, ActionProvider pActionProvider);

        // ���һ��������Ϣ
        RecentActive GetModel(RecentActive pRecentActiveFullInfo);

        // ��ȡ������Ϣ�б�
        List<RecentActive> GetList(RecentActive pRecentActiveFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
