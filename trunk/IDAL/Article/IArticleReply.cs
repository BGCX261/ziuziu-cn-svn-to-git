using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IArticleReply
    {
        // ������Ϣ�ظ�
        int Save(ArticleReply pArticleReplyFullInfo, ActionProvider pActionProvider);

        // ���һ����Ϣ�ظ�
        ArticleReply GetModel(ArticleReply pArticleReplyFullInfo);

        // ��ȡ��Ϣ�ظ��б�
        List<ArticleReply> GetList(ArticleReply pArticleReplyFullInfo, PageFullInfo pPageFullInfo);

        // ��������
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
