using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
namespace Ziuziu.Common
{
    /// <summary>
    /// �����ļ���Web.Config��������
    /// </summary>
    public sealed class ConfigHelper
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public ConfigHelper()
        {
        }
        /// <summary>
        /// ��appSettings��ȡ�ø����������ýڵ�ֵ,���Ѹ�ֵת��ΪBool��
        /// </summary>
        /// <param name="key">���ý�����</param>
        /// <returns>valueֵ</returns>
        public static bool GetConfigBool(string key)
        {
            bool flag = false;
            string configString = GetConfigString(key);
            if ((configString != null) && (string.Empty != configString))
            {
                try
                {
                    flag = bool.Parse(configString);
                }
                catch (FormatException)
                {
                }
            }
            return flag;
        }

        /// <summary>
        /// ��appSettings��ȡ�ø����������ýڵ�ֵ,���Ѹ�ֵת��Ϊdecimal��
        /// </summary>
        /// <param name="key">���ý�����</param>
        /// <returns>valueֵ</returns>
        public static decimal GetConfigDecimal(string key)
        {
            decimal num = 0M;
            string configString = GetConfigString(key);
            if ((configString != null) && (string.Empty != configString))
            {
                try
                {
                    num = decimal.Parse(configString);
                }
                catch (FormatException)
                {
                }
            }
            return num;
        }

        /// <summary>
        /// ��appSettings��ȡ�ø����������ýڵ�ֵ,���Ѹ�ֵת��Ϊint��
        /// </summary>
        /// <param name="key">���ý�����</param>
        /// <returns>valueֵ</returns>
        public static int GetConfigInt(string key)
        {
            int num = 0;
            string configString = GetConfigString(key);
            if ((configString != null) && (string.Empty != configString))
            {
                try
                {
                    num = int.Parse(configString);
                }
                catch (FormatException)
                {
                }
            }
            return num;
        }

        /// <summary>
        /// ��appSettings��ȡ�ø����������ýڵ�ֵ
        /// </summary>
        /// <param name="key">���ý�����</param>
        /// <returns>valueֵ</returns>
        public static string GetConfigString(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }


    }


}
