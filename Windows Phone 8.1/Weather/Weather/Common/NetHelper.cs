using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Common
{
    /// <summary>
    /// 网络相关
    /// </summary>
    public static class NetHelper
    {
        /// <summary>
        /// 网络是否开启
        /// </summary>
        /// <returns></returns>
        public static bool IsNetworkAvailable()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }
    }
}
