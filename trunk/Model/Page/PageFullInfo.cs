using System;
using System.Text;

namespace Ziuziu.Model
{
    public class PageFullInfo
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public PageFullInfo()
        {
            this._PageSize=20;
            this._PageIndex = 1;
            this._RecordNum = 0;
        }
        private int _PageSize;
        private int _PageIndex;
        private int _RecordNum;

        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize
        {
            set { _PageSize = value; }
            get { return _PageSize; }
        }
        /// <summary>
        /// 页索引
        /// </summary>
        public int PageIndex
        {
            set { _PageIndex = value; }
            get { return _PageIndex; }
        }
        /// <summary>
        /// 信息总数
        /// </summary>
        public int RecordNum
        {
            set { _RecordNum = value; }
            get { return _RecordNum; }
        }
    }
}
