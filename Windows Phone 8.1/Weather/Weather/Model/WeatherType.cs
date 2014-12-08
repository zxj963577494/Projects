using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Model
{
    /// <summary>
    /// 天气种类
    /// </summary>
    public class WeatherType
    {
        /// <summary>
        /// 天气唯一标识
        /// </summary>
        public string Wid { get; set; }

        /// <summary>
        /// 天气
        /// </summary>
        public string Weather { get; set; }
    }
}
