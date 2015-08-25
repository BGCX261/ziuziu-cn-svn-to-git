using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IActiveType
    {
        // �����Ա�״̬����
        int Save(ActiveType pActiveTypeFullInfo, ActionProvider pActionProvider);

        // ���һ����Ա�״̬����
        ActiveType GetModel(ActiveType pActiveTypeFullInfo);

        // ��ȡ��Ա�״̬�����б�
        List<ActiveType> GetList(ActiveType pActiveTypeFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
