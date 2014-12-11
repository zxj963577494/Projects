using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Model;
using Weather.Service.Message.General;

namespace Service.Implementations
{
    public class WeatherByCityService
    {
        public async Task<GetWeatherRespose> GetWeatherAsync(GetWeatherByCityNameOrIdRequest request)
        {
            GetWeatherRespose respose = new GetWeatherRespose();
            string requestUrl = request.GetRequestUrl();
            string resposeString = await Weather.Utils.HttpHelper.GetUrlRespose(requestUrl);
            respose = Weather.Utils.JsonSerializeHelper.JsonDeserialize<GetWeatherRespose>(resposeString);
            return respose;
        }
    }
}
