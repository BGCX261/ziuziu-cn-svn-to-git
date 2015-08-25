using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface ITags
    {
        // �����ǩ
        int Save(Tags pTagsFullInfo, ActionProvider pActionProvider);

        // ���һ����ǩ��Ϣ
        Tags GetModel(Tags pTagsFullInfo);

        // ��ȡ��ǩ��Ϣ�б�
        List<Tags> GetList(Tags pTagsFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
