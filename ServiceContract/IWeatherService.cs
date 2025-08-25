using ServiceContract.Dtos;

namespace ServiceContract
{
    public interface IWeatherService
    {
        Task<WeatherSummaryDto> GetWeatherSummaryAsync(double lat, double lon, DateOnly date, CancellationToken ct = default);
    }
}
