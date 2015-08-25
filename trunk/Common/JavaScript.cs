using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;

namespace Ziuziu.Common
{
    /// <summary>
    /// 显示消息提示对话框。
    /// CrownJoe
    /// 2008.3.1
    /// </summary>
    public class JavaScript
    {
        private JavaScript()
        {
        }
        /// <summary>
        /// 功能：在客户端注册一块脚本语言,在Page对象的 form 元素的结束标记之前发出该脚本
        /// 输入：page   网页中的Page对象
        /// script 欲注册的JavaScript脚本，需要包括 script language=javascript 等标签
        /// 输出：无。
        /// </summary>
        /// <param name="page">网页中的Page对象(this)</param>
        /// <param name="script">欲注册的JavaScript脚本，需要包括 script language=javascript 等标签</param>
        public static void RegisterStartupScript(System.Web.UI.Page page, string script)
        {
            string strKey;
            int i;
            //注册脚本块的Key
            strKey = System.DateTime.Now.ToString();
            //循环，直至找到某个没被注册过的Key
            for (i = 0; i < 100; i++)
                if (!page.IsStartupScriptRegistered(strKey + i.ToString()))
                    break;
            page.RegisterStartupScript(strKey + i.ToString(), script);
        }
        /// <summary>
        /// 功能：在客户端注册一块脚本语言,在Page对象的 form runat= server 元素的开始标记后立即发出该脚本
        /// 输入：page   网页中的Page对象
        /// script 欲注册的JavaScript脚本，需要包括 script language=javascript 等标签
        /// 输出：无。
        /// </summary>
        /// <param name="page">网页中的Page对象(this)</param>
        /// <param name="script">欲注册的JavaScript脚本，需要包括 script language=javascript 等标签</param>
        public static void RegisterClientScriptBlock(System.Web.UI.Page page, string script)
        {
            string strKey;
            int i;
            //注册脚本块的Key
            strKey = System.DateTime.Now.ToString();
            //循环，直至找到某个没被注册过的Key
            for (i = 0; i < 100; i++)
                if (!page.IsClientScriptBlockRegistered(strKey + i.ToString()))
                    break;
            page.RegisterClientScriptBlock(strKey + i.ToString(), script);
        }
        /// <summary>
        /// 功能：执行客户端一小块脚本语言,在Page对象的 form runat= server 元素的开始标记后立即发出该脚本
        /// 输入：page   网页中的Page对象
        ///       script 欲执行的JavaScript脚本，没有 script language=javascript 等标签
        /// 输出：无。
        /// </summary>
        /// <param name="page">page   网页中的Page对象</param>
        /// <param name="script">script 欲执行的JavaScript脚本,没有 script language=javascript 等标签</param>
        public static void ExecuteBlock(System.Web.UI.Page page, string script)
        {
            string strScript;
            //脚本块的内容
            strScript = "<script language=javascript>\n";
            strScript += " " + script + ";";
            strScript += "</script>";
            RegisterClientScriptBlock(page, strScript);

        }
        /// <summary>
        /// 功能：执行客户端一小块脚本语言,在Page对象的 form runat= server 元素的结束标记之前发出该脚本
        /// 输入：page   网页中的Page对象
        ///script 欲执行的JavaScript脚本
        /// 输出：无。
        /// </summary>
        /// <param name="page">网页中的Page对象</param>
        /// <param name="script">欲执行的JavaScript脚本,没有 script language=javascript 等标签</param>
        public static void ExecuteStartup(System.Web.UI.Page page, string script)
        {
            string strScript;
            //脚本块的内容
            strScript = "<script language=javascript>\n";
            strScript += " " + script + ";";
            strScript += "</script>";
            RegisterStartupScript(page, strScript);
        }
        /// <summary>
        /// 在Page对象的 form runat= server 元素的结束标记之前发出alert(msg)
        /// </summary>
        /// <param name="page">this</param>
        /// <param name="msg">消息</param>
        public static void ShowMessageStartup(System.Web.UI.Page page, string msg)
        {
            ExecuteStartup(page, "alert('" + msg + "');");
        }
        /// <summary>
        /// 在Page对象的 form runat= server 元素的开始标记后立即发出alert(msg)
        /// </summary>
        /// <param name="page">this</param>
        /// <param name="msg">消息</param>
        public static void ShowMessageBlock(System.Web.UI.Page page, string msg)
        {
            ExecuteBlock(page, "alert('" + msg + "');");
        }
        /// <summary>
        /// 控件点击 消息确认提示框
        /// </summary>
        /// <param name="Control">要邦定的控件</param>
        /// <param name="msg">提示信息</param>
        public static void ShowConfirm(System.Web.UI.WebControls.WebControl Control, string msg)
        {
            Control.Attributes.Add("onclick", "return confirm('" + msg + "');");
        }
        /// <summary>
        /// 显示消息提示对话框，并进行页面跳转
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        /// <param name="url">跳转的目标URL</param>
        public static void ShowMessageAndRedirect(System.Web.UI.Page page, string msg, string url)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.AppendFormat("top.location.href='{0}'", url);
            ExecuteStartup(page, Builder.ToString());
        }
        /// <summary>
        /// 显示消息提示对话框，并进行页面跳转
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        /// <param name="url">跳转的目标URL</param>
        /// <param name="thisortop">当前要调转的头eg:top\window\this等</param>
        public static void ShowMessageAndRedirect(System.Web.UI.Page page, string msg, string url, string thisortop)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.AppendFormat("{0}.location.href='{1}'", thisortop, url);
            ExecuteStartup(page, Builder.ToString());
        }

        /// <summary>
        /// 直接跳转一个页面
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="url">跳转的目标URL</param>
        public static void ShowRedirect(System.Web.UI.Page page, string url)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendFormat("top.location.href='{0}'", url);
            ExecuteStartup(page, Builder.ToString());
        }
        /// <summary>
        /// 显示消息提示对话框，并进行页面跳转
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        /// <param name="url">跳转的目标URL</param>
        /// <param name="thisortop">this指当前框架，top指顶端框架，还可以是别的</param>
        public static void ShowMessageRedirect(System.Web.UI.Page page, string msg, string url, string thisortop)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.AppendFormat("{0}.location.href='{1}'", thisortop, url);
            ExecuteStartup(page, Builder.ToString());
        }
        /// <summary>
        /// 直接跳转
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="url">跳转的目标URL</param>
        /// <param name="thisortop">this指当前框架，top指顶端框架，还可以是别的</param>
        public static void Show_Redirect(System.Web.UI.Page page,string url, string thisortop)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendFormat("{0}.location.href='{1}'", thisortop, url);
            ExecuteStartup(page, Builder.ToString());
        }
        /// <summary>
        /// 显示消息提示对话框，并返回。
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        public static void ShowMessageAndBack(System.Web.UI.Page page, string msg)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.Append("history.go(-1)");
            ExecuteStartup(page, Builder.ToString());
        }
        /// <summary>
        /// 提示信息，然后跳转
        /// </summary>
        /// <param name="str"></param>
        /// <param name="url"></param>
        public static void cjHistoryUrl(string str,string url)
        {
            HttpContext.Current.Response.Write("<script language=javascript>");
            HttpContext.Current.Response.Write(" alert('" + str + "');");
            HttpContext.Current.Response.Write(" top.location='"+ url + "';");
            HttpContext.Current.Response.Write( "</script>");
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
        /// <summary>
        /// 提示信息，然后跳转
        /// </summary>
        /// <param name="str"></param>
        /// <param name="url"></param>
        public static void cjNowGoUrl(string str, string url)
        {
            HttpContext.Current.Response.Write("<script language=javascript>");
            HttpContext.Current.Response.Write(" alert('" + str + "');");
            HttpContext.Current.Response.Write("window.location='" + url + "';");
            HttpContext.Current.Response.Write("</script>");
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
        /// <summary>
        /// 提示信息，后退
        /// </summary>
        /// <param name="str"></param>
        public static void javascript_history(string str)
        {
            System.Web.HttpContext.Current.Response.Write("<script defer>window.alert('" + str + "');history.back();</script>");
            HttpContext.Current.ApplicationInstance.CompleteRequest();
            //和response.end()方法一致，但是稍有区别，CompleteRequest跳过 Application_EndRequest 事件的代码执行，不会出现终止线程
        }
        /// <summary>
        /// 提示信息，关闭窗口
        /// </summary>
        /// <param name="str"></param>
        public static void javascript_close(string str)
        {
            System.Web.HttpContext.Current.Response.Write("<script defer>window.alert('" + str + "');window.close(this);</script>");
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="str"></param>
        public static void javascript_alert(string str)
        {
            System.Web.HttpContext.Current.Response.Write("<script defer>window.alert('" + str + "');</script>");
        }
    }
}
