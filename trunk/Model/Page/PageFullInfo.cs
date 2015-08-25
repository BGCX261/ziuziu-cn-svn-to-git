using System;
using System.Text;

namespace Ziuziu.Model
{
    public class PageFullInfo
    {
        /// <summary>
        /// Ĭ�Ϲ��캯��
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
        /// ҳ��С
        /// </summary>
        public int PageSize
        {
            set { _PageSize = value; }
            get { return _PageSize; }
        }
        /// <summary>
        /// ҳ����
        /// </summary>
        public int PageIndex
        {
            set { _PageIndex = value; }
            get { return _PageIndex; }
        }
        /// <summary>
        /// ��Ϣ����
        /// </summary>
        public int RecordNum
        {
            set { _RecordNum = value; }
            get { return _RecordNum; }
        }
    }
}
