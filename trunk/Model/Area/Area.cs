using System;
using System.Collections.Generic;
using System.Text;

namespace Ziuziu.Model
{
    /// <summary>
    /// 实体类Area 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class Area
    {
        public Area()
        { }
        #region Model
        private int _id=0;
        private string _areaname= string.Empty;
        private string _areacode = string.Empty;
        private bool _flag=false;
        private string _shortname = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// nvarchar
        /// </summary>
        public string AreaName
        {
            set { _areaname = value; }
            get { return _areaname; }
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
        public bool Flag
        {
            set { _flag = value; }
            get { return _flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShortName
        {
            set { _shortname = value; }
            get { return _shortname; }
        }
        #endregion Model

    }
}
