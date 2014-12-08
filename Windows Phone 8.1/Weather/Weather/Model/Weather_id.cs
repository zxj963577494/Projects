using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Model
{
    /// <summary>
    /// 天气唯一标识
    /// </summary>
    public class Weather_id
    {
        /// <summary>
        /// 天气标识 [00：晴]
        /// </summary>
        public WeatherTypes Fa { get; set; }

        /// <summary>
        /// 天气标识 [53：霾 如果fa不等于fb，说明是组合天气]
        /// </summary>
        public WeatherTypes Fb { get; set; }

    }
}
