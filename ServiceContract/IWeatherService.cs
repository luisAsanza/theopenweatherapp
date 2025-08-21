using ServiceContract.Dtos;

namespace ServiceContract
{
    public interface IWeatherService
    {
        WeatherSummaryDto GetWeatherSummary(string lat, string lon, DateTime date);
    }
}
