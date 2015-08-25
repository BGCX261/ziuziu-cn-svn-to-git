using System;

namespace Ziuziu.Common
{
    /// <summary>
    /// ���ݿ������������
    /// </summary>
    public enum ActionProvider : int 
    {
        /// <summary>
        /// �޶���
        /// </summary>
        None=0,
        /// <summary>
        /// ������¼
        /// </summary>
        Select = 1,
        /// <summary>
        /// �����¼�¼
        /// </summary>
        Insert =2,
        /// <summary>
        /// ���¼�¼
        /// </summary>
        Update = 3,
        /// <summary>
        /// ɾ����¼
        /// </summary>
        Delete = 4,
        /// <summary>
        /// �Ƽ���¼
        /// </summary>
        Commend = 5,
        /// <summary>
        /// �ö���¼
        /// </summary>
        Top = 6,
        /// <summary>
        /// ���ü�¼
        /// </summary>
        Forbid = 7,
        /// <summary>
        /// ��˼�¼
        /// </summary>
        Check = 8,


        /// <summary>
        /// ����ɾ��
        /// </summary>
        UnDelete = -4,
        /// <summary>
        /// ȡ���Ƽ�
        /// </summary>
        UnCommend = -5,
        /// <summary>
        /// ȡ���ö�
        /// </summary>
        UnTop = -6,
        /// <summary>
        /// �������
        /// </summary>
        UnForbid = -7,
        /// <summary>
        /// ȡ�����
        /// </summary>
        UnCheck = -8,
    }
}
