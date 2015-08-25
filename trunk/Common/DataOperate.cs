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
        /// 拆分标签（文章关键字）
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="url">查询跳转网址</param>
        /// <returns></returns>
        public static string tagLink(string str,string url)
        {
            //按照空格拆分数组
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
