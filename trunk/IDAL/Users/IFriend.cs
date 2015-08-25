using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IFriend
    {
        // 保存好友
        int Save(Friend pFriendFullInfo, ActionProvider pActionProvider);

        // 获得一条好友
        Friend GetModel(Friend pFriendFullInfo);

        // 获取好友列表
        List<Friend> GetList(Friend pFriendFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
