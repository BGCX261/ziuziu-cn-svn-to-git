using System;
using System.Collections.Generic;
using System.Text;

namespace Ziuziu.Model
{
    /// <summary>
    /// ʵ����Article ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class Article
    {
        public Article()
        { }
        #region Model
        private int _id = 0;
        private string _title = string.Empty;
        private string _content = string.Empty;
        private DateTime _adddate = DateTime.Now;
        private string _ip = string.Empty;
        private int _userid = 0;
        private int _classid = 0;
        private string _summary = string.Empty;
        private int _totalhits = 0;
        private bool _isdraft = false;
        private DateTime _updatedate = DateTime.Now;
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
        public int ClassID
        {
            set { _classid = value; }
            get { return _classid; }
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
        public int TotalHits
        {
            set { _totalhits = value; }
            get { return _totalhits; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDraft
        {
            set { _isdraft = value; }
            get { return _isdraft; }
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
