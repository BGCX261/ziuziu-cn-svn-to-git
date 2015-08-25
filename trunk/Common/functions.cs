using System;
using System.Web;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Ziuziu.Model;


namespace Ziuziu.Common
{
    public class functions
    {
        public functions()
        {
            ///构造函数
        }
        /// <summary>
        /// 取得一个控件值
        /// </summary>
        /// <param name="controlId">控件name</param>
        /// <param name="bol">是否过滤</param>
        /// <returns></returns>
        public static string getFormCotrolValue(string controlId,bool bol)
        {
            string result = System.Web.HttpContext.Current.Request[controlId];
            if (string.IsNullOrEmpty(result) || result.Trim()=="")
            {
                result = "";
            }
            else
            {
                result = result.Trim();
                if (bol)
                {
                    result = FiltrateScript(result);
                }
            }
            return result;
        }
        
        /// <summary>
        /// 属性Session["LoginTimes"]
        /// </summary>
        public static string session_LoginTimes
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["LoginTimes"] != null)
                {
                    return System.Web.HttpContext.Current.Session["LoginTimes"].ToString();
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// 属性Session["username"]
        /// </summary>
        public static string session_username
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["username"]!=null)
                {
                    return System.Web.HttpContext.Current.Session["username"].ToString();
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// 属性Session["Roleid"]
        /// </summary>
        public static string session_roleid
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["Roleid"] != null)
                {
                    return System.Web.HttpContext.Current.Session["Roleid"].ToString();
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// 属性SessionID
        /// </summary>
        public static string session_ID
        {
            get
            {
                if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Session.SessionID) && (System.Web.HttpContext.Current.Session.SessionID).Trim() != "")
                {
                    return System.Web.HttpContext.Current.Session.SessionID;
                }
                else
                {
                    return "";
                }
            }
        }
       
        /// <summary>
        /// 取得IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetIp()
        {
            string str = "";
            //穿过代理服务器取远程用户真实IP地址：
            if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
                str = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            else
                str = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
            return str;
        }

        #region 加密与解密
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="str"></param>
        /// <param name="bo">是否加随机数</param>
        /// <returns></returns>
        public string crownjoe(string str,bool bo)
        {
            char[] cs = str.ToCharArray();
            byte[] by;
            string results = "", temp = "";
            for (int i = 0; i < cs.Length; i++)
            {
                by = System.Text.Encoding.UTF8.GetBytes(cs[i].ToString());
                temp = Convert.ToBase64String(by);//每个字转换为四位
                if (bo)
                {
                    temp += rand(10, 99).ToString();//同时加两个随机变量
                }
                results += temp;//（每个变为6位）全部相加
            }
            //results = String.
            //System.Convert.ToString(results,
            return results;
        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="str"></param>
		/// <param name="t">要和上面的对应，如果加了随机数则t值应该为6，不加的话是4，否则出错</param>
        /// <returns></returns>
        public string joecrown(string str,int t)
        {
            string result = "", strtemp = "";
            try
            {
                char[] cs = str.ToCharArray();
                string[] temp = ArrayListstr(str,t);
                byte[] by;
                for (int i = 0; i < temp.Length; i++)
                {
                    strtemp = (temp[i].ToString()).Substring(0, 4);
                    by = Convert.FromBase64String(strtemp);
                    result += System.Text.Encoding.UTF8.GetString(by);
                }
                return result;
            }
            catch
            {
                return "异常信息";
            }
        }
        #endregion

        /// <summary>
        /// 把一个字符串按照t位长度分割为数组
        /// </summary>
        /// <param name="str"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public string[] ArrayListstr(string str, int n)
        {
            string[] result;
            try
            {
                if (n <= 0)
                {
                    n = str.Length;
                }
                int arrynum = 0;
                arrynum = (int)(str.Length / n);
                if (arrynum <= 0)
                {
                    arrynum = 1;
                }
                result = new string[arrynum];
                for (int i = 0; i < arrynum; i++)
                {
                    result[i] = str.Substring(n * i, n);
                }
            }
            catch
            {
                result = new string[1] { "异常信息" };
            }
            return result;
        }

        /// <summary>
        /// 生成随机数
        /// </summary>
        /// <returns></returns>
        private int rand(int x, int y)
        {
            Random ran = new Random();
            int num = ran.Next(x, y);
            return num;
        }
        
        /// <summary>
        /// 过滤简单的脚本代码,
        /// </summary>
        /// <param name="HTML">输入值,少量值使用</param>
        /// <returns></returns>
        public static string FiltrateScript(string HTML)
        {
            Regex regex1 = new Regex(@"<script[\s\S]+</script *>", RegexOptions.IgnoreCase);
            Regex regex2 = new Regex(@"href *= *[\s\S]*script *:", RegexOptions.IgnoreCase);
            Regex regex3 = new Regex(@"onload=", RegexOptions.IgnoreCase);
            Regex regex4 = new Regex(@"<iframe[\s\S]+</iframe *>", RegexOptions.IgnoreCase);
            Regex regex5 = new Regex(@"<frameset[\s\S]+</frameset *>", RegexOptions.IgnoreCase);
            HTML = HTML.Trim();
            HTML = regex1.Replace(HTML, "");  //过滤<script></script>标记 
            HTML = regex2.Replace(HTML, ""); //过滤href=javascript: (<A>) 属性 
            HTML = regex3.Replace(HTML, ""); //过滤其它控件的on...事件 
            HTML = regex4.Replace(HTML, ""); //过滤iframe 
            HTML = regex5.Replace(HTML, ""); //过滤frameset return HTML; 
            return HTML;
        } 
        /// <summary>
        /// 过滤html代码
        /// </summary>
        /// <param name="HTML">输入值</param>
        /// <param name="returnLen">过滤之后取得的长度</param>
        /// <param name="cutLen">截取长度进行过滤</param>
        /// <returns></returns>
        public static string FiltrateScript(string HTML,int returnLen,int cutLen)
        {
            //Regex regex1 = new Regex(@"<script[\s\S]+</script *>", RegexOptions.IgnoreCase);
            //Regex regex2 = new Regex(@"href *= *[\s\S]*script *:", RegexOptions.IgnoreCase);
            //Regex regex3 = new Regex(@"onload=", RegexOptions.IgnoreCase);
            //Regex regex4 = new Regex(@"<iframe[\s\S]+</iframe *>", RegexOptions.IgnoreCase);
            //Regex regex5 = new Regex(@"<frameset[\s\S]+</frameset *>", RegexOptions.IgnoreCase);

            Regex regex12 = new Regex(@"<br[^>]*>", RegexOptions.IgnoreCase);
            Regex regex13 = new Regex(@"<[^>]*>", RegexOptions.IgnoreCase);//过滤所有<>标签，范围太广，暂不用
            Regex regex14 = new Regex(@"[^>]*>", RegexOptions.IgnoreCase);//过滤所有*>标签
            HTML = HTML.Trim();
            if (HTML.Length > cutLen)
                HTML = HTML.Substring(1, cutLen);
            HTML = regex12.Replace(HTML, "$www.ziuziu.cn$");
            HTML = regex13.Replace(HTML, "");
            HTML = regex14.Replace(HTML, "");
            HTML = HTML.Replace("$www.ziuziu.cn$","<br />");
           
            if (HTML.Length > returnLen)
                HTML = HTML.Substring(0, returnLen);
            return HTML;
        } 
        
        /// <summary>
        /// 获得逐级缩进的栏目名
        /// </summary>
        /// <param name="sName">栏目名</param>
        /// <param name="parentid">父id</param>
        /// <returns>逐级缩进的栏目名</returns>
        public static string getColumnListName(string sName, string parentid)
        {
            string sKongge="";
            if (int.Parse(parentid) > 0)
            {
                    //sStr = "<img src='/manager/images/tb_list" + i + ".gif'  align='absmiddle' > ";
                    sKongge += " &nbsp;&nbsp;&nbsp;&nbsp;";
            }
            return sKongge + sName;
        }
        /// <summary>
        /// 是否有新增模块按钮
        /// </summary>
        /// <param name="url">链接地址</param>
        /// <param name="parentid">父id</param>
        /// <returns></returns>
        public static string isadd(string url,string parentid)
        {
            string sKongge = "";
            if (parentid == "0")
            {
                sKongge = "<a href=" + url + ">新增模块</a>";
            }
            return sKongge;
        }
       
        public static void showHtmlMsg(string str)
        {
            System.Web.HttpContext.Current.Response.Write(str);
            System.Web.HttpContext.Current.Response.End();
        }
        /// <summary>
        /// 设置页面立即过期
        /// </summary>
        public static void overdue()
        {
            System.Web.HttpContext.Current.Response.AddHeader("Pragma", "No-Cache");
            System.Web.HttpContext.Current.Response.Buffer = true;
            System.Web.HttpContext.Current.Response.ExpiresAbsolute = DateTime.Now.AddSeconds(-1);
            System.Web.HttpContext.Current.Response.Expires = 0;
            System.Web.HttpContext.Current.Response.CacheControl = "no-cache";
        }


        public static void MemberLoginOut()
        {
                System.Web.HttpContext.Current.Session.Abandon();
                System.Web.HttpContext.Current.Session.Clear();
                System.Web.HttpContext.Current.Session.RemoveAll();

                HttpCookie myCookie = new HttpCookie("ZiuUserID");
                if (myCookie != null)
                {
                    myCookie.Expires = DateTime.Now.AddDays(-1);
                }
                System.Web.HttpContext.Current.Response.Cookies.Add(myCookie);

                HttpCookie logintimes_cj = new HttpCookie("LoginTimes");
                if (logintimes_cj != null)
                {
                    logintimes_cj.Expires = DateTime.Now.AddDays(-1);
                }
                System.Web.HttpContext.Current.Response.Cookies.Add(logintimes_cj);

                HttpCookie Lasttime_cj = new HttpCookie("Lasttime");
                if (Lasttime_cj != null)
                {
                    Lasttime_cj.Expires = DateTime.Now.AddDays(-1);
                }
                System.Web.HttpContext.Current.Response.Cookies.Add(Lasttime_cj);

                HttpCookie BlogID_cj = new HttpCookie("BlogID");
                if (BlogID_cj != null)
                {
                    BlogID_cj.Expires = DateTime.Now.AddDays(-1);
                }
                System.Web.HttpContext.Current.Response.Cookies.Add(BlogID_cj);

                HttpCookie Email_cj = new HttpCookie("Email");
                if (Email_cj != null)
                {
                    Email_cj.Expires = DateTime.Now.AddDays(-1);
                }
                System.Web.HttpContext.Current.Response.Cookies.Add(Email_cj);
                JavaScript.cjHistoryUrl("安全退出", "/");

        }
        public static void MemIsLogin()
        {
            //if (System.Web.HttpContext.Current.Request.Cookies["ZiuUserID"] == null)
            //{
            //    if (System.Web.HttpContext.Current.Session["ZiuUserID"] == null || System.Web.HttpContext.Current.Session["LoginTimes"] == null)
            //        JavaScript.cjHistoryUrl("登录超时", "/login");
            //}
            if (userid=="")
            {
                  //JavaScript.cjHistoryUrl("请登录之后再进行次操作", "/login/");
                JavaScript.cjHistoryUrl("请登录之后再进行次操作", "/login/");
            }
            //System.Web.HttpContext.Current.Session["ZiuUserID"] = "admin";
        }
        /// <summary>
        /// 判断是否登录,返回bool
        /// </summary>
        /// <returns></returns>
        public static bool member_is_no_login()
        {
            bool result_=false;
            if (userid != "")
            {
                result_ = true; 
            }
            return result_;
        }
        /// <summary>
        /// 会员登陆的Email
        /// </summary>
        public static string Email
        {
            get
            {
                if (System.Web.HttpContext.Current.Request.Cookies["Email"] == null)
                {
                    if (System.Web.HttpContext.Current.Session["Email"] != null)
                        return HttpUtility.UrlDecode(System.Web.HttpContext.Current.Session["Email"].ToString(), System.Text.Encoding.UTF8);
                    else
                        return "";
                }
                else
                {
                    return HttpUtility.UrlDecode(System.Web.HttpContext.Current.Request.Cookies["Email"].Value.ToString(), System.Text.Encoding.UTF8);
                }
            }
        }
        /// <summary>
        /// 会员登陆的userid
        /// </summary>
        public static string userid
        {
            get
            {
                if (System.Web.HttpContext.Current.Request.Cookies["ZiuUserID"] == null)
                {
                    if (System.Web.HttpContext.Current.Session["ZiuUserID"] != null)
                        return HttpUtility.UrlDecode(System.Web.HttpContext.Current.Session["ZiuUserID"].ToString(), System.Text.Encoding.UTF8);
                    else
                        return "";
                }
                else
                {
                    return HttpUtility.UrlDecode(System.Web.HttpContext.Current.Request.Cookies["ZiuUserID"].Value.ToString(), System.Text.Encoding.UTF8);
                }
            }
        }
        /// <summary>
        /// 会员登陆次数
        /// </summary>
        public static string ziu_LoginTimes
        {
            get
            {
                if (System.Web.HttpContext.Current.Request.Cookies["LoginTimes"] == null)
                {
                    if (System.Web.HttpContext.Current.Session["LoginTimes"] != null)
                          return System.Web.HttpContext.Current.Session["LoginTimes"].ToString();
                    else
                          return "";
                }
                else
                {
                    return System.Web.HttpContext.Current.Request.Cookies["LoginTimes"].Value.ToString();
                }
            }
        }
        /// <summary>
        /// 会员登陆最后登陆时间
        /// </summary>
        public static string ziu_Lasttime
        {
            get
            {
                if (System.Web.HttpContext.Current.Request.Cookies["Lasttime"] == null)
                {
                    if (System.Web.HttpContext.Current.Session["Lasttime"] != null)
                         return System.Web.HttpContext.Current.Session["Lasttime"].ToString();
                     else
                         return "";
                }
                else
                {
                    return System.Web.HttpContext.Current.Request.Cookies["Lasttime"].Value.ToString();
                }
            }
        }
        /// <summary>
        /// 会员bolg名，eg:beacyqm
        /// </summary>
        public static string ziu_BlogID
        {
            get
            {
                if (System.Web.HttpContext.Current.Request.Cookies["BlogID"] == null)
                {
                    if (System.Web.HttpContext.Current.Session["BlogID"] != null)
                         return System.Web.HttpContext.Current.Session["BlogID"].ToString();
                    else
                         return "";
                }
                else
                {
                    return System.Web.HttpContext.Current.Request.Cookies["BlogID"].Value.ToString();
                }
            }
        }
        /// <summary>
        /// 取得当前页的URL
        /// </summary>
        /// <returns></returns>
        public static string GetNowUrl()
        {
            string url = System.Web.HttpContext.Current.Request.RawUrl;
           return url;
        }
        /// <summary>
        /// 获得上一页的URL
        /// </summary>
        /// <returns></returns>
        public static string GetPreviousUrl()
        {
            string url;
            try
            {
                url = System.Web.HttpContext.Current.Request.UrlReferrer.PathAndQuery;
            }
            catch
            {
                url = "";
            }
            return url;
        }
        /// <summary>
        /// 产生随机数
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Random(int min,int max)
        {
            Random num = new Random();
            return num.Next(min, max);
        }
        /// <summary>
        /// 防注入
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string safeRequest(string str)
        {
            str = str.Replace("'", "");
            return str;
        }
        #region 关键字编码转换
        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="strIn">输入关键字</param>
        /// <param name="encoding">编码形式 System.Text.Encoding.UTF8</param>
        /// <returns></returns>
        public static string StrUConv(string strIn, string encoding)
        {
            return System.Web.HttpUtility.UrlEncode(strIn, System.Text.Encoding.GetEncoding(encoding));
        }
        /// <summary>
        /// URL解码
        /// </summary>
        /// <param name="strIn">输入关键字</param>
        /// <param name="encoding">编码形式 System.Text.Encoding.UTF8</param>
        /// <returns></returns>
        public static string StrDConv(string strIn, string encoding)
        {
            return System.Web.HttpUtility.UrlDecode(strIn, System.Text.Encoding.Default);
        }

       
        #endregion

        /// <summary>
        /// 截取字符串，中文安两个字符处理
        /// </summary>
        /// <param name="stringToSub"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GetFirstString(string stringToSub, int length)
        {
            Regex regex = new Regex("[\u4e00-\u9fa5]+", RegexOptions.Compiled);
            char[] stringChar = stringToSub.ToCharArray();
            StringBuilder sb = new StringBuilder();
            int nLength = 0;
            bool isCut = false;
            for (int i = 0; i < stringChar.Length; i++)
            {
                if (regex.IsMatch((stringChar[i]).ToString()))
                {
                    sb.Append(stringChar[i]);
                    nLength += 2;
                }
                else
                {
                    sb.Append(stringChar[i]);
                    nLength = nLength + 1;
                }

                if (nLength > length)
                {
                    isCut = true;
                    break;
                }
            }
            if (isCut)
                return sb.ToString() + "...";
            else
                return sb.ToString();
        }

        public static string returnHtml(string str)
        {
            if (str.Trim() != "")
            {
                str = str.Replace("\n", "<br/>");
                str = str.Replace(" ", "&nbsp;");
            }
            return str;
        }
    }

}
