using System;
using System.Collections.Generic;
using System.Text;

namespace Ziuziu.Common
{
    public class ActiveType
    {
        /// <summary>
        /// 属性类ActiveType 。(以下属性用在会员操作表)
        /// </summary>
        public ActiveType() { }
        //以下四个都是同一个网址
        private string _UseQQ = "通过QQ发布了一条信息";
        private string _UseMSN= "通过MSN发布了一条信息";
        private string _UseWeb = "通过网页发布了一条信息";
        private string _UseMobile = "通过手机发布了一条信息";
        private string _UseMiniUrl = "";
        //相册url以及照片的url都需要
        private string _UpPhoto = "上传了{$PhotoNum}张照片到{$Album}";
        private string _UpAlbumUrl = "";

        private string _WriteTravel = "写了新游记";
        private string _WriteSight = "发布了新景点信息";
        private string _WriteEat = "发布了一篇关于吃喝的信息";
        private string _ReplyTravel = "回应了{$UserID}的游记";
        private string _ReplySight = "回应了{$UserID}的一篇景点信息";
        private string _ReplyEat = "回应了{$UserID}发布的一篇关于吃喝信息";
        private string _ReplyPhoto = "回应了{$UserID}的照片";
        private string _WantTo = "要去";
        private string _ThinkTo = "想去";
        private string _HadTo = "去过";
        private string _MakeFriend = "加{$UserID}为好友";
        private string _JionZiu = "成为我们的会员，大家去欢迎一下:)";
        private string _UpdateMyself = "更新了自己的资料";
        //回应的其他操作，比如送花送蛋糕等传情操作
        private string _ReplyOpearte = "";//直接使用表情说明即可
        private string _ReplyOpearteUrl = "";//直接到表情页面

        //通用，会员网址，信息网址，照片网址
        private string _UserUrl = "";
        private string _InfoUrl = "";
        private string _PhotoUrl = "";

       
        /// <summary>
        /// 通过QQ发布了一条信息
        /// </summary>
        public string UseQQ
        {
            set { _UseQQ = value; }
            get { return _UseQQ; }
        }
        /// <summary>
        /// 通过MSN发布了一条信息
        /// </summary>
        public string UseMSN
        {
            set { _UseMSN = value; }
            get { return _UseMSN; }
        }
        /// <summary>
        /// 通过网页发布了一条信息
        /// </summary>
        public string UseWeb
        {
            set { _UseWeb = value; }
            get { return _UseWeb; }
        }
        /// <summary>
        /// 通过手机发布了一条信息
        /// </summary>
        public string UseMobile
        {
            set { _UseMobile = value; }
            get { return _UseMobile; }
        }
        /// <summary>
        /// 通过TWritter发布该信息的网址
        /// </summary>
        public string UseMiniUrl
        {
            set { _UseMiniUrl = value; }
            get { return _UseMiniUrl; }
        }
        /// <summary>
        /// 上传了{$PhotoNum}张照片到{$Album}
        /// </summary>
        public string UpPhoto
        {
            set { _UpPhoto = value; }
            get { return _UpPhoto; }
        }
        /// <summary>
        /// 相册网址
        /// </summary>
        public string UpAlbumUrl
        {
            set { _UpAlbumUrl = value; }
            get { return _UpAlbumUrl; }
        }
        /// <summary>
        /// 写了新游记
        /// </summary>
        public string WriteTravel
        {
            set { _WriteTravel = value; }
            get { return _WriteTravel; }
        }
        /// <summary>
        ///  发布了新景点信息
        /// </summary>
        public string WriteSight
        {
            set { _WriteSight = value; }
            get { return _WriteSight; }
        }
        /// <summary>
        ///  发布了一篇关于吃喝的信息
        /// </summary>
        public string WriteEat
        {
            set { _WriteEat = value; }
            get { return _WriteEat; }
        }
        /// <summary>
        ///  回应了{$UserID}的游记
        /// </summary>
        public string ReplyTravel
        {
            set { _ReplyTravel = value; }
            get { return _ReplyTravel; }
        }
        /// <summary>
        ///  回应了{$UserID}的一篇景点信息
        /// </summary>
        public string ReplySight
        {
            set { _ReplySight = value; }
            get { return _ReplySight; }
        }
        /// <summary>
        /// 回应了{$UserID}发布的一篇关于吃喝信息
        /// </summary>
        public string ReplyEat
        {
            set { _ReplyEat = value; }
            get { return _ReplyEat; }
        }
        /// <summary>
        /// 回应了{$UserID}的照片
        /// </summary>
        public string ReplyPhoto
        {
            set { _ReplyPhoto = value; }
            get { return _ReplyPhoto; }
        }
        /// <summary>
        /// 要去
        /// </summary>
        public string WantTo
        {
            set { _WantTo = value; }
            get { return _WantTo; }
        }
        /// <summary>
        /// 想去
        /// </summary>
        public string ThinkTo
        {
            set { _ThinkTo = value; }
            get { return _ThinkTo; }
        }
        /// <summary>
        /// 去过
        /// </summary>
        public string HadTo
        {
            set { _HadTo = value; }
            get { return _HadTo; }
        }
        /// <summary>
        /// 加{$UserID}为好友
        /// </summary>
        public string MakeFriend
        {
            set { _MakeFriend = value; }
            get { return _MakeFriend; }
        }
        /// <summary>
        ///  成为我们的会员，大家去欢迎一下:)
        /// </summary>
        public string JionZiu
        {
            set { _JionZiu = value; }
            get { return _JionZiu; }
        }
        /// <summary>
        ///  更新了自己的资料
        /// </summary>
        public string UpdateMyself
        {
            set { _UpdateMyself = value; }
            get { return _UpdateMyself; }
        }
        /// <summary>
        /// 回应的其他操作，比如送花送蛋糕等传情操作
        /// </summary>
        public string ReplyOpearte
        {
            set { _ReplyOpearte = value; }
            get { return _ReplyOpearte; }
        }
        /// <summary>
        /// 回应的其他操作传情的url,直接到表情页面
        /// </summary>
        public string ReplyOpearteUrl
        {
            set { _ReplyOpearteUrl = value; }
            get { return _ReplyOpearteUrl; }
        }
        /// <summary>
        /// 会员链接
        /// </summary>
        public string UserUrl
        {
            set { _UserUrl = value; }
            get { return _UserUrl; }
        }
        /// <summary>
        /// 信息链接
        /// </summary>
        public string InfoUrl
        {
            set { _InfoUrl = value; }
            get { return _InfoUrl; }
        }
        /// <summary>
        /// 照片链接
        /// </summary>
        public string PhotoUrl
        {
            set { _PhotoUrl = value; }
            get { return _PhotoUrl; }
        }
    }
}
