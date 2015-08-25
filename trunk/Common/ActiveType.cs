using System;
using System.Collections.Generic;
using System.Text;

namespace Ziuziu.Common
{
    public class ActiveType
    {
        /// <summary>
        /// ������ActiveType ��(�����������ڻ�Ա������)
        /// </summary>
        public ActiveType() { }
        //�����ĸ�����ͬһ����ַ
        private string _UseQQ = "ͨ��QQ������һ����Ϣ";
        private string _UseMSN= "ͨ��MSN������һ����Ϣ";
        private string _UseWeb = "ͨ����ҳ������һ����Ϣ";
        private string _UseMobile = "ͨ���ֻ�������һ����Ϣ";
        private string _UseMiniUrl = "";
        //���url�Լ���Ƭ��url����Ҫ
        private string _UpPhoto = "�ϴ���{$PhotoNum}����Ƭ��{$Album}";
        private string _UpAlbumUrl = "";

        private string _WriteTravel = "д�����μ�";
        private string _WriteSight = "�������¾�����Ϣ";
        private string _WriteEat = "������һƪ���ڳԺȵ���Ϣ";
        private string _ReplyTravel = "��Ӧ��{$UserID}���μ�";
        private string _ReplySight = "��Ӧ��{$UserID}��һƪ������Ϣ";
        private string _ReplyEat = "��Ӧ��{$UserID}������һƪ���ڳԺ���Ϣ";
        private string _ReplyPhoto = "��Ӧ��{$UserID}����Ƭ";
        private string _WantTo = "Ҫȥ";
        private string _ThinkTo = "��ȥ";
        private string _HadTo = "ȥ��";
        private string _MakeFriend = "��{$UserID}Ϊ����";
        private string _JionZiu = "��Ϊ���ǵĻ�Ա�����ȥ��ӭһ��:)";
        private string _UpdateMyself = "�������Լ�������";
        //��Ӧ�����������������ͻ��͵���ȴ������
        private string _ReplyOpearte = "";//ֱ��ʹ�ñ���˵������
        private string _ReplyOpearteUrl = "";//ֱ�ӵ�����ҳ��

        //ͨ�ã���Ա��ַ����Ϣ��ַ����Ƭ��ַ
        private string _UserUrl = "";
        private string _InfoUrl = "";
        private string _PhotoUrl = "";

       
        /// <summary>
        /// ͨ��QQ������һ����Ϣ
        /// </summary>
        public string UseQQ
        {
            set { _UseQQ = value; }
            get { return _UseQQ; }
        }
        /// <summary>
        /// ͨ��MSN������һ����Ϣ
        /// </summary>
        public string UseMSN
        {
            set { _UseMSN = value; }
            get { return _UseMSN; }
        }
        /// <summary>
        /// ͨ����ҳ������һ����Ϣ
        /// </summary>
        public string UseWeb
        {
            set { _UseWeb = value; }
            get { return _UseWeb; }
        }
        /// <summary>
        /// ͨ���ֻ�������һ����Ϣ
        /// </summary>
        public string UseMobile
        {
            set { _UseMobile = value; }
            get { return _UseMobile; }
        }
        /// <summary>
        /// ͨ��TWritter��������Ϣ����ַ
        /// </summary>
        public string UseMiniUrl
        {
            set { _UseMiniUrl = value; }
            get { return _UseMiniUrl; }
        }
        /// <summary>
        /// �ϴ���{$PhotoNum}����Ƭ��{$Album}
        /// </summary>
        public string UpPhoto
        {
            set { _UpPhoto = value; }
            get { return _UpPhoto; }
        }
        /// <summary>
        /// �����ַ
        /// </summary>
        public string UpAlbumUrl
        {
            set { _UpAlbumUrl = value; }
            get { return _UpAlbumUrl; }
        }
        /// <summary>
        /// д�����μ�
        /// </summary>
        public string WriteTravel
        {
            set { _WriteTravel = value; }
            get { return _WriteTravel; }
        }
        /// <summary>
        ///  �������¾�����Ϣ
        /// </summary>
        public string WriteSight
        {
            set { _WriteSight = value; }
            get { return _WriteSight; }
        }
        /// <summary>
        ///  ������һƪ���ڳԺȵ���Ϣ
        /// </summary>
        public string WriteEat
        {
            set { _WriteEat = value; }
            get { return _WriteEat; }
        }
        /// <summary>
        ///  ��Ӧ��{$UserID}���μ�
        /// </summary>
        public string ReplyTravel
        {
            set { _ReplyTravel = value; }
            get { return _ReplyTravel; }
        }
        /// <summary>
        ///  ��Ӧ��{$UserID}��һƪ������Ϣ
        /// </summary>
        public string ReplySight
        {
            set { _ReplySight = value; }
            get { return _ReplySight; }
        }
        /// <summary>
        /// ��Ӧ��{$UserID}������һƪ���ڳԺ���Ϣ
        /// </summary>
        public string ReplyEat
        {
            set { _ReplyEat = value; }
            get { return _ReplyEat; }
        }
        /// <summary>
        /// ��Ӧ��{$UserID}����Ƭ
        /// </summary>
        public string ReplyPhoto
        {
            set { _ReplyPhoto = value; }
            get { return _ReplyPhoto; }
        }
        /// <summary>
        /// Ҫȥ
        /// </summary>
        public string WantTo
        {
            set { _WantTo = value; }
            get { return _WantTo; }
        }
        /// <summary>
        /// ��ȥ
        /// </summary>
        public string ThinkTo
        {
            set { _ThinkTo = value; }
            get { return _ThinkTo; }
        }
        /// <summary>
        /// ȥ��
        /// </summary>
        public string HadTo
        {
            set { _HadTo = value; }
            get { return _HadTo; }
        }
        /// <summary>
        /// ��{$UserID}Ϊ����
        /// </summary>
        public string MakeFriend
        {
            set { _MakeFriend = value; }
            get { return _MakeFriend; }
        }
        /// <summary>
        ///  ��Ϊ���ǵĻ�Ա�����ȥ��ӭһ��:)
        /// </summary>
        public string JionZiu
        {
            set { _JionZiu = value; }
            get { return _JionZiu; }
        }
        /// <summary>
        ///  �������Լ�������
        /// </summary>
        public string UpdateMyself
        {
            set { _UpdateMyself = value; }
            get { return _UpdateMyself; }
        }
        /// <summary>
        /// ��Ӧ�����������������ͻ��͵���ȴ������
        /// </summary>
        public string ReplyOpearte
        {
            set { _ReplyOpearte = value; }
            get { return _ReplyOpearte; }
        }
        /// <summary>
        /// ��Ӧ���������������url,ֱ�ӵ�����ҳ��
        /// </summary>
        public string ReplyOpearteUrl
        {
            set { _ReplyOpearteUrl = value; }
            get { return _ReplyOpearteUrl; }
        }
        /// <summary>
        /// ��Ա����
        /// </summary>
        public string UserUrl
        {
            set { _UserUrl = value; }
            get { return _UserUrl; }
        }
        /// <summary>
        /// ��Ϣ����
        /// </summary>
        public string InfoUrl
        {
            set { _InfoUrl = value; }
            get { return _InfoUrl; }
        }
        /// <summary>
        /// ��Ƭ����
        /// </summary>
        public string PhotoUrl
        {
            set { _PhotoUrl = value; }
            get { return _PhotoUrl; }
        }
    }
}
