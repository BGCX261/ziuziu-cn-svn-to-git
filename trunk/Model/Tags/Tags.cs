using System;
using System.Collections.Generic;
using System.Text;

namespace Ziuziu.Model
{
    /// <summary>
    /// ʵ����Tags ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class Tags
    {
        public Tags()
        { }
        #region Model
        private int _id = 0;
        private string _tagname = string.Empty;
        private string _areacode = string.Empty;
        private int _infoid = 0;
        private bool _flag = false;
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
        public string TagName
        {
            set { _tagname = value; }
            get { return _tagname; }
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
        public int InfoID
        {
            set { _infoid = value; }
            get { return _infoid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool Flag
        {
            set { _flag = value; }
            get { return _flag; }
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
