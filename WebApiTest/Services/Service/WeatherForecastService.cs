using WebApiTest.Services.Interface;

namespace WebApiTest.Services.Service
{
    public class WeatherForecastService: IWeatherForecastService
    {
        public string GetForecast()
        {
            var forecast = "Sunny today with High of 90 degrees F";
            return forecast;
        }

        public string GetHurricaneRoute()
        {
            var route = "Hurricane is currently a CAT 3 with sustained winds of 130mph. Route is headed for cuba";
            return route;
        }
    }
}
