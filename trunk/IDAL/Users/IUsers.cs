using System;
using System.Collections.Generic;
using Ziuziu.Model;
using Ziuziu.Common;

namespace Ziuziu.IDAL
{
    public interface IUsers
    {
        // 保存会员信息
        int Save(Users pUsersFullInfo, ActionProvider pActionProvider);

        // 获得一条会员信息
        Users GetModel(Users pUsersFullInfo);

        // 获取会员信息列表
        List<Users> GetList(Users pUsersFullInfo, PageFullInfo pPageFullInfo);

        // 批量处理
        int Batch(string pIDList, ActionProvider pActionProvider);
    }
}
