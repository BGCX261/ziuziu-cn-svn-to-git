using System;
using System.Collections.Generic;
using System.Text;

namespace Ziuziu.Common
{
    public class blog
    {
        /// <summary>
        /// µ√µΩµÿ÷∑¿∏url
        /// </summary>
        /// <returns></returns>
        public string url()
        {
            return System.Web.HttpContext.Current.Request.Url.ToString();
        }
    }
}
