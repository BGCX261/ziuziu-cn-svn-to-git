using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;

namespace Ziuziu.Common
{
    /// <summary>
    /// ��ʾ��Ϣ��ʾ�Ի���
    /// CrownJoe
    /// 2008.3.1
    /// </summary>
    public class JavaScript
    {
        private JavaScript()
        {
        }
        /// <summary>
        /// ���ܣ��ڿͻ���ע��һ��ű�����,��Page����� form Ԫ�صĽ������֮ǰ�����ýű�
        /// ���룺page   ��ҳ�е�Page����
        /// script ��ע���JavaScript�ű�����Ҫ���� script language=javascript �ȱ�ǩ
        /// ������ޡ�
        /// </summary>
        /// <param name="page">��ҳ�е�Page����(this)</param>
        /// <param name="script">��ע���JavaScript�ű�����Ҫ���� script language=javascript �ȱ�ǩ</param>
        public static void RegisterStartupScript(System.Web.UI.Page page, string script)
        {
            string strKey;
            int i;
            //ע��ű����Key
            strKey = System.DateTime.Now.ToString();
            //ѭ����ֱ���ҵ�ĳ��û��ע�����Key
            for (i = 0; i < 100; i++)
                if (!page.IsStartupScriptRegistered(strKey + i.ToString()))
                    break;
            page.RegisterStartupScript(strKey + i.ToString(), script);
        }
        /// <summary>
        /// ���ܣ��ڿͻ���ע��һ��ű�����,��Page����� form runat= server Ԫ�صĿ�ʼ��Ǻ����������ýű�
        /// ���룺page   ��ҳ�е�Page����
        /// script ��ע���JavaScript�ű�����Ҫ���� script language=javascript �ȱ�ǩ
        /// ������ޡ�
        /// </summary>
        /// <param name="page">��ҳ�е�Page����(this)</param>
        /// <param name="script">��ע���JavaScript�ű�����Ҫ���� script language=javascript �ȱ�ǩ</param>
        public static void RegisterClientScriptBlock(System.Web.UI.Page page, string script)
        {
            string strKey;
            int i;
            //ע��ű����Key
            strKey = System.DateTime.Now.ToString();
            //ѭ����ֱ���ҵ�ĳ��û��ע�����Key
            for (i = 0; i < 100; i++)
                if (!page.IsClientScriptBlockRegistered(strKey + i.ToString()))
                    break;
            page.RegisterClientScriptBlock(strKey + i.ToString(), script);
        }
        /// <summary>
        /// ���ܣ�ִ�пͻ���һС��ű�����,��Page����� form runat= server Ԫ�صĿ�ʼ��Ǻ����������ýű�
        /// ���룺page   ��ҳ�е�Page����
        ///       script ��ִ�е�JavaScript�ű���û�� script language=javascript �ȱ�ǩ
        /// ������ޡ�
        /// </summary>
        /// <param name="page">page   ��ҳ�е�Page����</param>
        /// <param name="script">script ��ִ�е�JavaScript�ű�,û�� script language=javascript �ȱ�ǩ</param>
        public static void ExecuteBlock(System.Web.UI.Page page, string script)
        {
            string strScript;
            //�ű��������
            strScript = "<script language=javascript>\n";
            strScript += " " + script + ";";
            strScript += "</script>";
            RegisterClientScriptBlock(page, strScript);

        }
        /// <summary>
        /// ���ܣ�ִ�пͻ���һС��ű�����,��Page����� form runat= server Ԫ�صĽ������֮ǰ�����ýű�
        /// ���룺page   ��ҳ�е�Page����
        ///script ��ִ�е�JavaScript�ű�
        /// ������ޡ�
        /// </summary>
        /// <param name="page">��ҳ�е�Page����</param>
        /// <param name="script">��ִ�е�JavaScript�ű�,û�� script language=javascript �ȱ�ǩ</param>
        public static void ExecuteStartup(System.Web.UI.Page page, string script)
        {
            string strScript;
            //�ű��������
            strScript = "<script language=javascript>\n";
            strScript += " " + script + ";";
            strScript += "</script>";
            RegisterStartupScript(page, strScript);
        }
        /// <summary>
        /// ��Page����� form runat= server Ԫ�صĽ������֮ǰ����alert(msg)
        /// </summary>
        /// <param name="page">this</param>
        /// <param name="msg">��Ϣ</param>
        public static void ShowMessageStartup(System.Web.UI.Page page, string msg)
        {
            ExecuteStartup(page, "alert('" + msg + "');");
        }
        /// <summary>
        /// ��Page����� form runat= server Ԫ�صĿ�ʼ��Ǻ���������alert(msg)
        /// </summary>
        /// <param name="page">this</param>
        /// <param name="msg">��Ϣ</param>
        public static void ShowMessageBlock(System.Web.UI.Page page, string msg)
        {
            ExecuteBlock(page, "alert('" + msg + "');");
        }
        /// <summary>
        /// �ؼ���� ��Ϣȷ����ʾ��
        /// </summary>
        /// <param name="Control">Ҫ��Ŀؼ�</param>
        /// <param name="msg">��ʾ��Ϣ</param>
        public static void ShowConfirm(System.Web.UI.WebControls.WebControl Control, string msg)
        {
            Control.Attributes.Add("onclick", "return confirm('" + msg + "');");
        }
        /// <summary>
        /// ��ʾ��Ϣ��ʾ�Ի��򣬲�����ҳ����ת
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="msg">��ʾ��Ϣ</param>
        /// <param name="url">��ת��Ŀ��URL</param>
        public static void ShowMessageAndRedirect(System.Web.UI.Page page, string msg, string url)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.AppendFormat("top.location.href='{0}'", url);
            ExecuteStartup(page, Builder.ToString());
        }
        /// <summary>
        /// ��ʾ��Ϣ��ʾ�Ի��򣬲�����ҳ����ת
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="msg">��ʾ��Ϣ</param>
        /// <param name="url">��ת��Ŀ��URL</param>
        /// <param name="thisortop">��ǰҪ��ת��ͷeg:top\window\this��</param>
        public static void ShowMessageAndRedirect(System.Web.UI.Page page, string msg, string url, string thisortop)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.AppendFormat("{0}.location.href='{1}'", thisortop, url);
            ExecuteStartup(page, Builder.ToString());
        }

        /// <summary>
        /// ֱ����תһ��ҳ��
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="url">��ת��Ŀ��URL</param>
        public static void ShowRedirect(System.Web.UI.Page page, string url)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendFormat("top.location.href='{0}'", url);
            ExecuteStartup(page, Builder.ToString());
        }
        /// <summary>
        /// ��ʾ��Ϣ��ʾ�Ի��򣬲�����ҳ����ת
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="msg">��ʾ��Ϣ</param>
        /// <param name="url">��ת��Ŀ��URL</param>
        /// <param name="thisortop">thisָ��ǰ��ܣ�topָ���˿�ܣ��������Ǳ��</param>
        public static void ShowMessageRedirect(System.Web.UI.Page page, string msg, string url, string thisortop)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.AppendFormat("{0}.location.href='{1}'", thisortop, url);
            ExecuteStartup(page, Builder.ToString());
        }
        /// <summary>
        /// ֱ����ת
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="url">��ת��Ŀ��URL</param>
        /// <param name="thisortop">thisָ��ǰ��ܣ�topָ���˿�ܣ��������Ǳ��</param>
        public static void Show_Redirect(System.Web.UI.Page page,string url, string thisortop)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendFormat("{0}.location.href='{1}'", thisortop, url);
            ExecuteStartup(page, Builder.ToString());
        }
        /// <summary>
        /// ��ʾ��Ϣ��ʾ�Ի��򣬲����ء�
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="msg">��ʾ��Ϣ</param>
        public static void ShowMessageAndBack(System.Web.UI.Page page, string msg)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.Append("history.go(-1)");
            ExecuteStartup(page, Builder.ToString());
        }
        /// <summary>
        /// ��ʾ��Ϣ��Ȼ����ת
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
        /// ��ʾ��Ϣ��Ȼ����ת
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
        /// ��ʾ��Ϣ������
        /// </summary>
        /// <param name="str"></param>
        public static void javascript_history(string str)
        {
            System.Web.HttpContext.Current.Response.Write("<script defer>window.alert('" + str + "');history.back();</script>");
            HttpContext.Current.ApplicationInstance.CompleteRequest();
            //��response.end()����һ�£�������������CompleteRequest���� Application_EndRequest �¼��Ĵ���ִ�У����������ֹ�߳�
        }
        /// <summary>
        /// ��ʾ��Ϣ���رմ���
        /// </summary>
        /// <param name="str"></param>
        public static void javascript_close(string str)
        {
            System.Web.HttpContext.Current.Response.Write("<script defer>window.alert('" + str + "');window.close(this);</script>");
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
        /// <summary>
        /// ��ʾ��Ϣ
        /// </summary>
        /// <param name="str"></param>
        public static void javascript_alert(string str)
        {
            System.Web.HttpContext.Current.Response.Write("<script defer>window.alert('" + str + "');</script>");
        }
    }
}
