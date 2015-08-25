using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
namespace Ziuziu.Common
{
    /// <summary>
    /// 配置文件（Web.Config）管理器
    /// </summary>
    public sealed class ConfigHelper
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ConfigHelper()
        {
        }
        /// <summary>
        /// 从appSettings中取得给定名字配置节的值,并把改值转换为Bool型
        /// </summary>
        /// <param name="key">配置节名称</param>
        /// <returns>value值</returns>
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
        /// 从appSettings中取得给定名字配置节的值,并把改值转换为decimal型
        /// </summary>
        /// <param name="key">配置节名称</param>
        /// <returns>value值</returns>
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
        /// 从appSettings中取得给定名字配置节的值,并把改值转换为int型
        /// </summary>
        /// <param name="key">配置节名称</param>
        /// <returns>value值</returns>
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
        /// 从appSettings中取得给定名字配置节的值
        /// </summary>
        /// <param name="key">配置节名称</param>
        /// <returns>value值</returns>
        public static string GetConfigString(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }


    }


}
