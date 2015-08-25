using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IArticle
    {
        // 保存信息
        //int Save(Article pArticleFullInfo, ActionProvider pActionProvider);

        // 添加信息
        int Add(Article pArticleFullInfo, ActionProvider pActionProvider);

        // 更新信息
        int Update(Article pArticleFullInfo, ActionProvider pActionProvider);

        // 获得一条信息
        Article GetModel(int pID);

        // 获取信息列表
        List<Article> GetList(Article pArticleFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
