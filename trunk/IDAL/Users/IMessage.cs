using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IMessage
    {
        // ����վ����Ϣ
        int Save(Message pMessageFullInfo, ActionProvider pActionProvider);

        // ���һ��վ����Ϣ
        Message GetModel(Message pMessageFullInfo);

        // ��ȡվ����Ϣ�б�
        List<Message> GetList(Message pMessageFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
