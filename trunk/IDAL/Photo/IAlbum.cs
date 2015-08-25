using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IAlbum
    {
        // �������
        int Save(Album pAlbumFullInfo, ActionProvider pActionProvider);

        // ���һ�������Ϣ
        Album GetModel(Album pAlbumFullInfo);

        // ��ȡ�����Ϣ�б�
        List<Album> GetList(Album pAlbumFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
