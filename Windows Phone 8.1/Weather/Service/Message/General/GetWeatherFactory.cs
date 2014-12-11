using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Service.Message.General
{
    public class GetWeatherRequestFactory
    {
        private static IGetWeatherRequest getWeatherRequest = null;
        private static GetWeatherRespose getWeatherRespose = null;


        //public static IGetWeatherRequest CreateGetWeatherRequest(GetWeatherMode mode)
        //{
        //    switch (mode)
        //    {
        //        case GetWeatherMode.City:
        //            getWeatherRequest=new GetWeatherByCityNameOrIdRequest();
        //            break;
        //        case GetWeatherMode.Gps:
        //            getWeatherRequest = new GetWeatherByGpsRequest();
        //            break;
        //        case GetWeatherMode.Ip:
        //            getWeatherRequest = new GetWeatherByIpRequest();
        //            break;
        //        default:
        //            getWeatherRequest = new GetWeatherByCityNameOrIdRequest();
        //            break;
        //    }
        //    return getWeatherRequest;
        //}

        //public static GetWeatherRespose CreteGetWeatherRespose(GetWeatherMode mode)
        //{
        //    switch (mode)
        //    {
        //        case GetWeatherMode.City:
        //            getWeatherRequest = new GetWeatherByCityNameOrIdRequest();
        //            break;
        //        case GetWeatherMode.Gps:
        //            getWeatherRequest = new GetWeatherByGpsRequest();
        //            break;
        //        case GetWeatherMode.Ip:
        //            getWeatherRequest = new GetWeatherByIpRequest();
        //            break;
        //        default:
        //            getWeatherRequest = new GetWeatherByCityNameOrIdRequest();
        //            break;
        //    }
        //    return getWeatherRespose;
        //}

    }
}
