using ServiceContract.Dtos;

namespace ServiceContract
{
    public interface IWeatherService
    {
        Task<WeatherSummaryDto> GetWeatherSummary(string lat, string lon, DateTime date);
    }
}
