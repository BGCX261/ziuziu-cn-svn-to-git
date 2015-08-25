using System;
using System.Collections.Generic;
using System.Text;

namespace Ziuziu.Model
{
    /// <summary>
    /// 实体类RecentActive 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class RecentActive
    {
        public RecentActive()
        { }
        #region Model
        private int _id = 0;
        private int _userid = 0;
        private string _content = string.Empty;
        private DateTime _adddate = DateTime.Now;
        private int _activetype = 0;
        private bool _ischeck = false;
        private bool _isdelete = false;
        private bool _issee = false;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int UserId
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ActiveType
        {
            set { _activetype = value; }
            get { return _activetype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsCheck
        {
            set { _ischeck = value; }
            get { return _ischeck; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDelete
        {
            set { _isdelete = value; }
            get { return _isdelete; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsSee
        {
            set { _issee = value; }
            get { return _issee; }
        }
        #endregion Model

    }
}
