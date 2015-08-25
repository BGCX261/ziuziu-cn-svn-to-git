using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IArticle
    {
        // ������Ϣ
        //int Save(Article pArticleFullInfo, ActionProvider pActionProvider);

        // �����Ϣ
        int Add(Article pArticleFullInfo, ActionProvider pActionProvider);

        // ������Ϣ
        int Update(Article pArticleFullInfo, ActionProvider pActionProvider);

        // ���һ����Ϣ
        Article GetModel(int pID);

        // ��ȡ��Ϣ�б�
        List<Article> GetList(Article pArticleFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
