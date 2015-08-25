using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IUsers
    {
        // �����Ա��Ϣ
        int Save(Users pUsersFullInfo, ActionProvider pActionProvider);

        // ���һ����Ա��Ϣ
        Users GetModel(Users pUsersFullInfo);

        // ��ȡ��Ա��Ϣ�б�
        List<Users> GetList(Users pUsersFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
