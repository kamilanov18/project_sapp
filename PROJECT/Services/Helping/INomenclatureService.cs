using Models.DTOs.Internal;

namespace Services.Helping
{
    public interface INomenclatureService
    {
        Task<List<NomenclatureDTO<int>>> GetEcontCities(string countryCode);
        Task<List<NomenclatureDTO<string>>> GetEcontCountries();
        Task<List<NomenclatureDTO<int>>> GetEcontStreets(int cityId);
    }
}
