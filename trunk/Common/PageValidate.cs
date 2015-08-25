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
        /// �ַ�������
        /// </summary>
        public PageValidate()
        {
        }

        private static Regex RegCHZN = new Regex("[\u4e00-\u9fa5]");
        private static Regex RegDecimal = new Regex("^[0-9]+[.]?[0-9]+$");
        private static Regex RegDecimalSign = new Regex("^[+-]?[0-9]+[.]?[0-9]+$"); //�ȼ���^[+-]?\d+[.]?\d+$
        private static Regex RegEmail = new Regex("^[\\w-]+@[\\w-]+\\.(com|cn|com.cn|net|org|edu|mil|tv|biz|info)$");//w Ӣ����ĸ�����ֵ��ַ������� [a-zA-Z0-9] �﷨һ�� 
        private static Regex RegNumber = new Regex("^[0-9]+$");
        private static Regex RegNumberEng = new Regex("^[a-zA-Z0-9]");//Ӣ����ĸ�����ֵ��ַ���
        private static Regex RegNumberSign = new Regex("^[+-]?[0-9]+$");
        private static Regex RegOutSpecial = new Regex("[^%&',;?$\x22]+");//���ܺ���^%&',;?$\"���ַ�

        /// <summary>
        /// �൱��Server.Decode(String)
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
        /// �൱��Server.Encode(String)
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
        /// ��HttpRequest.QueryString["name"]����HttpRequest.Form["name"]��ѡȡ�ض����ȵ��ַ���
        /// </summary>
        /// <param name="req">HttpRequest����(Request)</param>
        /// <param name="inputKey">�൱��HttpRequest.QueryString["name"]�е�"name"</param>
        /// <param name="maxLen">Ҫȡ����󳤶�</param>
        /// <returns>���ȡ�õ��ַ���</returns>
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
        /// ���������^%&',;=?$\"�������ַ�
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsRegOutSpecial(string str)
        {
            return RegOutSpecial.IsMatch(str);
        }


        /// <summary>
        /// ��֤����
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsEmail(string email)
        {
            return RegEmail.Match(email).Success;
        }
        /// <summary>
        /// ����
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
