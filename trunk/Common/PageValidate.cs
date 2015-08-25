using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;
namespace Ziuziu.Common
{
    public class PageValidate
    {
        /// <summary>
        /// 字符串处理
        /// </summary>
        public PageValidate()
        {
        }

        private static Regex RegCHZN = new Regex("[\u4e00-\u9fa5]");
        private static Regex RegDecimal = new Regex("^[0-9]+[.]?[0-9]+$");
        private static Regex RegDecimalSign = new Regex("^[+-]?[0-9]+[.]?[0-9]+$"); //等价于^[+-]?\d+[.]?\d+$
        private static Regex RegEmail = new Regex("^[\\w-]+@[\\w-]+\\.(com|cn|com.cn|net|org|edu|mil|tv|biz|info)$");//w 英文字母或数字的字符串，和 [a-zA-Z0-9] 语法一样 
        private static Regex RegNumber = new Regex("^[0-9]+$");
        private static Regex RegNumberEng = new Regex("^[a-zA-Z0-9]");//英文字母或数字的字符串
        private static Regex RegNumberSign = new Regex("^[+-]?[0-9]+$");
        private static Regex RegOutSpecial = new Regex("[^%&',;?$\x22]+");//不能含有^%&',;?$\"等字符

        /// <summary>
        /// 相当于Server.Decode(String)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Decode(string str)
        {
            str = str.Replace("<br>", "\n");
            str = str.Replace("&gt;", ">");
            str = str.Replace("&lt;", "<");
            str = str.Replace("&nbsp;", " ");
            str = str.Replace("&quot;", "\"");
            return str;
        }
        /// <summary>
        /// 相当于Server.Encode(String)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Encode(string str)
        {
            str = str.Replace("&", "&amp;");
            str = str.Replace("'", "''");
            str = str.Replace("\"", "&quot;");
            str = str.Replace(" ", "&nbsp;");
            str = str.Replace("<", "&lt;");
            str = str.Replace(">", "&gt;");
            str = str.Replace("\n", "<br>");
            return str;
        }
        /// <summary>
        /// 从HttpRequest.QueryString["name"]或者HttpRequest.Form["name"]中选取特定长度的字符串
        /// </summary>
        /// <param name="req">HttpRequest对象(Request)</param>
        /// <param name="inputKey">相当于HttpRequest.QueryString["name"]中的"name"</param>
        /// <param name="maxLen">要取得最大长度</param>
        /// <returns>最后取得的字符串</returns>
        public static string FetchInputDigit(HttpRequest req, string inputKey, int maxLen)
        {
            string sqlInput = string.Empty;
            if ((inputKey != null) && (inputKey != string.Empty))
            {
                sqlInput = req.QueryString[inputKey];
                if (sqlInput == null)
                {
                    sqlInput = req.Form[inputKey];
                }
                if (sqlInput != null)
                {
                    sqlInput = SqlText(sqlInput, maxLen);
                    if (!IsNumber(sqlInput))
                    {
                        sqlInput = string.Empty;
                    }
                }
            }
            if (sqlInput == null)
            {
                sqlInput = string.Empty;
            }
            return sqlInput;
        }

        public static string HtmlEncode(string inputData)
        {
            return HttpUtility.HtmlEncode(inputData);
        }

        public static string InputText(string inputString, int maxLength)
        {
            StringBuilder builder = new StringBuilder();
            if ((inputString != null) && (inputString != string.Empty))
            {
                inputString = inputString.Trim();
                if (inputString.Length > maxLength)
                {
                    inputString = inputString.Substring(0, maxLength);
                }
                for (int i = 0; i < inputString.Length; i++)
                {
                    switch (inputString[i])
                    {
                        case '<':
                            {
                                builder.Append("&lt;");
                                continue;
                            }
                        case '>':
                            {
                                builder.Append("&gt;");
                                continue;
                            }
                        case '"':
                            {
                                builder.Append("&quot;");
                                continue;
                            }
                    }
                    builder.Append(inputString[i]);
                }
                builder.Replace("'", " ");
            }
            return builder.ToString();
        }

        public static bool IsDecimal(string inputData)
        {
            return RegDecimal.Match(inputData).Success;
        }
        public static bool IsNumEng(string str)
        {
            return RegNumberEng.Match(str).Success;
        }

        public static bool IsDecimalSign(string inputData)
        {
            return RegDecimalSign.Match(inputData).Success;
        }
        /// <summary>
        /// 不允许出现^%&',;=?$\"等特殊字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsRegOutSpecial(string str)
        {
            return RegOutSpecial.IsMatch(str);
        }


        /// <summary>
        /// 验证邮箱
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsEmail(string email)
        {
            return RegEmail.Match(email).Success;
        }
        /// <summary>
        /// 中文
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public static bool IsHasCHZN(string inputData)
        {
            return RegCHZN.Match(inputData).Success;
        }

        public static bool IsNumber(string inputData)
        {
            return RegNumber.Match(inputData).Success;
        }

        public static bool IsNumberSign(string inputData)
        {
            return RegNumberSign.Match(inputData).Success;
        }

        public static void SetLabel(Label lbl, object inputObj)
        {
            SetLabel(lbl, inputObj.ToString());
        }

        public static void SetLabel(Label lbl, string txtInput)
        {
            lbl.Text = HtmlEncode(txtInput);
        }

        public static string SqlText(string sqlInput, int maxLength)
        {
            if ((sqlInput != null) && (sqlInput != string.Empty))
            {
                sqlInput = sqlInput.Trim();
                if (sqlInput.Length > maxLength)
                {
                    sqlInput = sqlInput.Substring(0, maxLength);
                }
            }
            return sqlInput;
        }

    }


}
