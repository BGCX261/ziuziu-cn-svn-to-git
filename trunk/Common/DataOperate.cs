using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using System.Data;

namespace Ziuziu.Common
{
    public class DataOperate
    {
        public void DataListBind(DataList dl,DataSet ds)
        {
            dl.DataSource = ds.Tables[0].DefaultView;
            dl.DataBind();
        }
        /// <summary>
        /// ��ֱ�ǩ�����¹ؼ��֣�
        /// </summary>
        /// <param name="str">�ַ���</param>
        /// <param name="url">��ѯ��ת��ַ</param>
        /// <returns></returns>
        public static string tagLink(string str,string url)
        {
            //���տո�������
            string[] arry = str.Split(' ');
            string result="";
            for (int i = 0; i < arry.Length; i++)
            {
                result += "<a href='" + url + "?keywords=" + System.Web.HttpUtility.UrlEncode((arry[i])) + "' class='green' target='_blank'>" + arry[i] + "</a>  ";
                //result += "<a href='" + url + "?keywords=" + System.Web.HttpContext.Current.Server.((arry[i])) + "' class='green' target='_blank'>" + arry[i] + "</a>  ";
            }
            return result;
            //Server.UrlEncode(strValue);

        }
    }
}
