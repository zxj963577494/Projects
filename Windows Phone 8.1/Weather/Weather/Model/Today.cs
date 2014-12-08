using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Model
{
    /// <summary>
    /// 今日天气
    /// </summary>
    public class Today
    {
        /// <summary>
        /// 城市 [天津]
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 日期 [2014年03月21日]
        /// </summary>
        public string Date_y { get; set; }

        /// <summary>
        /// 星期 [星期五]
        /// </summary>
        public string Week { get; set; }

        /// <summary>
        /// 今日温度 [8℃~20℃]
        /// </summary>
        public string Temperature { get; set; }

        /// <summary>
        /// 今日天气 [晴转霾]
        /// </summary>
        public string Weather { get; set; }

        /// <summary>
        /// 天气唯一标识
        /// </summary>
        public Weather_id Weather_id { get; set; }

        /// <summary>
        /// 风向风力 [西南风微风]
        /// </summary>
        public string Wind { get; set; }

        /// <summary>
        /// 穿衣指数 [较冷]
        /// </summary>
        public string Dressing_index { get; set; }

        /// <summary>
        /// 穿衣建议 [建议着大衣、呢外套加毛衣、卫衣等服装。]
        /// </summary>
        public string Dressing_advice { get; set; }

        /// <summary>
        /// 紫外线强度 [中等]
        /// </summary>
        public string Uv_index { get; set; }

        /// <summary>
        /// 舒适度指数 [中等]
        /// </summary>
        public string Comfort_index { get; set; }

        /// <summary>
        /// 洗车指数 [较适宜]
        /// </summary>
        public string Wash_index { get; set; }

        /// <summary>
        /// 旅游指数 [适宜]
        /// </summary>
        public string Travel_index { get; set; }

        /// <summary>
        /// 晨练指数 [较适宜]
        /// </summary>
        public string Exercise_index { get; set; }

        /// <summary>
        /// 干燥指数 [中等]
        /// </summary>
        public string Drying_index { get; set; }










    }
}
