using ServiceContract.Dtos;

namespace ServiceContract
{
    public interface ICitiesService
    {
        List<CityDto> GetCities();
    }
}
