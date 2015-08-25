using System;

namespace Ziuziu.Common
{
    /// <summary>
    /// 数据库操作动作类型
    /// </summary>
    public enum ActionProvider : int 
    {
        /// <summary>
        /// 无动作
        /// </summary>
        None=0,
        /// <summary>
        /// 检索记录
        /// </summary>
        Select = 1,
        /// <summary>
        /// 插入新记录
        /// </summary>
        Insert =2,
        /// <summary>
        /// 更新记录
        /// </summary>
        Update = 3,
        /// <summary>
        /// 删除记录
        /// </summary>
        Delete = 4,
        /// <summary>
        /// 推荐记录
        /// </summary>
        Commend = 5,
        /// <summary>
        /// 置顶记录
        /// </summary>
        Top = 6,
        /// <summary>
        /// 禁用记录
        /// </summary>
        Forbid = 7,
        /// <summary>
        /// 审核记录
        /// </summary>
        Check = 8,


        /// <summary>
        /// 回收删除
        /// </summary>
        UnDelete = -4,
        /// <summary>
        /// 取消推荐
        /// </summary>
        UnCommend = -5,
        /// <summary>
        /// 取消置顶
        /// </summary>
        UnTop = -6,
        /// <summary>
        /// 解除禁用
        /// </summary>
        UnForbid = -7,
        /// <summary>
        /// 取消审核
        /// </summary>
        UnCheck = -8,
    }
}
