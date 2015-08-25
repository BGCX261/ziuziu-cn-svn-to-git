using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IFriend
    {
        // �������
        int Save(Friend pFriendFullInfo, ActionProvider pActionProvider);

        // ���һ������
        Friend GetModel(Friend pFriendFullInfo);

        // ��ȡ�����б�
        List<Friend> GetList(Friend pFriendFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
