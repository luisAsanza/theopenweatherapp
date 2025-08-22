using ServiceContract.Dtos;

namespace ServiceContract
{
    public interface ICitiesService
    {
        IEnumerable<CityDto> GetCities();
    }
}
