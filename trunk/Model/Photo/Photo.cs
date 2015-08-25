using System;
using System.Collections.Generic;
using System.Text;

namespace Ziuziu.Model
{
    /// <summary>
    /// 实体类Photo 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class Photo
    {
        public Photo()
        { }
        #region Model
        private int _id = 0;
        private string _summary = string.Empty;
        private DateTime _adddate = DateTime.Now;
        private int _totalhits = 0;
        private string _bigpic = string.Empty;
        private string _smallpic = string.Empty;
        private int _albumid = 0;
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
        public int TotalHits
        {
            set { _totalhits = value; }
            get { return _totalhits; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BigPic
        {
            set { _bigpic = value; }
            get { return _bigpic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SmallPic
        {
            set { _smallpic = value; }
            get { return _smallpic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int AlbumID
        {
            set { _albumid = value; }
            get { return _albumid; }
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
