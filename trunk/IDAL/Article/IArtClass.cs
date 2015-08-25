using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IArtClass
    {
        // ������Ϣ���
        int Save(ArtClass pArtClassFullInfo, ActionProvider pActionProvider);

        // ���һ����Ϣ���
        ArtClass GetModel(ArtClass pArtClassFullInfo);

        // ��ȡ������Ϣ���
        List<ArtClass> GetList(ArtClass pArtClassFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
