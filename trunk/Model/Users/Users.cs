using System;
using System.Collections.Generic;
using System.Text;

namespace Ziuziu.Model
{
    /// <summary>
    /// 实体类Users 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class Users
    {
        public Users()
        { }
        #region Model
        private int _id = 0;
        private string _nick = string.Empty;
        private string _email = string.Empty;
        private string _pwd = string.Empty;
        private string _domainname = string.Empty;
        private string _areacode = string.Empty;
        private DateTime _regdate = DateTime.Now;
        private bool _sex = false;
        private DateTime _birthday = DateTime.Now;
        private string _brief = string.Empty;
        private string _pic = string.Empty;
        private string _blog = string.Empty;
        private int _logintimes = 0;
        private DateTime _lastdate = DateTime.Now;
        private string _lastip = string.Empty;
        private int _visittimes = 0;
        private bool _isforbid = false;
        private int _loginstatus = 0;
        private bool _isdelete = false;
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
        public string Nick
        {
            set { _nick = value; }
            get { return _nick; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pwd
        {
            set { _pwd = value; }
            get { return _pwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DomainName
        {
            set { _domainname = value; }
            get { return _domainname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AreaCode
        {
            set { _areacode = value; }
            get { return _areacode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime RegDate
        {
            set { _regdate = value; }
            get { return _regdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Brief
        {
            set { _brief = value; }
            get { return _brief; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pic
        {
            set { _pic = value; }
            get { return _pic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Blog
        {
            set { _blog = value; }
            get { return _blog; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int LoginTimes
        {
            set { _logintimes = value; }
            get { return _logintimes; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime LastDate
        {
            set { _lastdate = value; }
            get { return _lastdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LastIP
        {
            set { _lastip = value; }
            get { return _lastip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int VisitTimes
        {
            set { _visittimes = value; }
            get { return _visittimes; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsForbid
        {
            set { _isforbid = value; }
            get { return _isforbid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int LoginStatus
        {
            set { _loginstatus = value; }
            get { return _loginstatus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDelete
        {
            set { _isdelete = value; }
            get { return _isdelete; }
        }
        #endregion Model

    }
}
