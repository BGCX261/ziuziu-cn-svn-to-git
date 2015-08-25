using System;
using System.Collections.Generic;
using System.Text;

namespace Ziuziu.Model
{
    /// <summary>
    /// 实体类Album 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class Album
    {
        public Album()
        { }
        #region Model
        private int _id = 0;
        private string _title = string.Empty;
        private string _summary = string.Empty;
        private DateTime _adddate = DateTime.Now;
        private string _ip = string.Empty;
        private int _userid = 0;
        private DateTime _updatedate = DateTime.Now;
        private string _showpic = string.Empty;
        private bool _ischeck = false;
        private bool _isdelete = false;
        private int _iscommon = 0;
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
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Summary
        {
            set { _summary = value; }
            get { return _summary; }
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
        public string IP
        {
            set { _ip = value; }
            get { return _ip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateDate
        {
            set { _updatedate = value; }
            get { return _updatedate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShowPic
        {
            set { _showpic = value; }
            get { return _showpic; }
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
        public int IsCommon
        {
            set { _iscommon = value; }
            get { return _iscommon; }
        }
        #endregion Model

    }
}
