using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IPath
    {
        // �����㼣
        int Save(Path pPathFullInfo, ActionProvider pActionProvider);

        // ���һ���㼣��Ϣ
        Path GetModel(Path pPathFullInfo);

        // ��ȡ�㼣��Ϣ�б�
        List<Path> GetList(Path pPathFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
