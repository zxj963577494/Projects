using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Common
{
    public static class UrlHelper
    {
        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="p_Text"></param>
        /// <returns></returns>
        public static string GetUrlString(string p_Text)
        {
            byte[] _Value = Encoding.GetEncoding("utf8").GetBytes(p_Text);

            return "%" + BitConverter.ToString(_Value).Replace('-', '%');
        }
    }
}
