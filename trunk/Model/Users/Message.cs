using System;
using System.Collections.Generic;
using System.Text;

namespace Ziuziu.Model
{
    /// <summary>
    /// 实体类Message 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class Message
    {
        public Message()
        { }
        #region Model
        private int _id = 0;
        private string _fromid = string.Empty;
        private int _toid = 0;
        private string _title = string.Empty;
        private string _content = string.Empty;
        private DateTime _adddate = DateTime.Now;
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
        public string FromID
        {
            set { _fromid = value; }
            get { return _fromid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ToID
        {
            set { _toid = value; }
            get { return _toid; }
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
