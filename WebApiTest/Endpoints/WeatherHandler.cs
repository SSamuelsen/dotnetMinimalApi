using System.Text.Json;
using WebApiTest.Services.Interface;

namespace WebApiTest.Endpoints
{
    public class WeatherHandler: IEndpointRouteHandler
    {
        public void MapEndpoints(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/weather", (IWeatherForecastService weatherForecastService) =>
            {
                return Results.Ok(weatherForecastService.GetForecast());
            });

            app.MapGet("api/hurricaneRoute", (IWeatherForecastService weatherForecastService) =>
            {
                return Results.Ok(weatherForecastService.GetHurricaneRoute());
            });
        }
    }
}
