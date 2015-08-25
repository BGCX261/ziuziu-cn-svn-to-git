using System;
using System.Collections.Generic;
using System.Text;

namespace Ziuziu.Model
{
    /// <summary>
    /// 实体类ArticleReply 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class ArticleReply
    {
        public ArticleReply()
        { }
        #region Model
        private int _id = 0;
        private string _content = string.Empty;
        private DateTime _adddate = DateTime.Now;
        private string _ip = string.Empty;
        private int _userid = 0;
        private int _articleid = 0;
        private bool _ischeck = false;
        private bool _isdelete = false;
        private DateTime _updatedate = DateTime.Now;
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
        public int ArticleID
        {
            set { _articleid = value; }
            get { return _articleid; }
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
        public DateTime UpdateDate
        {
            set { _updatedate = value; }
            get { return _updatedate; }
        }
        #endregion Model

    }
}
