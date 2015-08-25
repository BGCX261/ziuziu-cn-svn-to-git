using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IArticleReply
    {
        // 保存信息回复
        int Save(ArticleReply pArticleReplyFullInfo, ActionProvider pActionProvider);

        // 获得一条信息回复
        ArticleReply GetModel(ArticleReply pArticleReplyFullInfo);

        // 获取信息回复列表
        List<ArticleReply> GetList(ArticleReply pArticleReplyFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
