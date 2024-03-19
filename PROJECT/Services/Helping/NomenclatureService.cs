using DataAccess.Data;
using Models.DTOs.Internal;
using Services.Shipping;

namespace Services.Helping
{
    public class NomenclatureService : INomenclatureService
    {
        private BizlabbgIcanContext _ctx;
        IShippingService _econtService;
        public NomenclatureService(BizlabbgIcanContext context,ShippingServiceResolver resolver)
        {
            _econtService = resolver.Resolve("econt");
            _ctx = context;
        }

        public async Task<List<NomenclatureDTO<int>>> GetEcontCities(string countryCode)
        {
            return (await _econtService.GetCities(countryCode)).Select(x => new NomenclatureDTO<int>() { Id = x.Id, Name = x.Name }).ToList();
        }

        public async Task<List<NomenclatureDTO<string>>> GetEcontCountries()
        {
            return (await _econtService.GetCountries()).Select(x => new NomenclatureDTO<string>() { Id=x.Code3,Name=x.Name }).ToList();
        }

        public async Task<List<NomenclatureDTO<int>>> GetEcontStreets(int cityId)
        {
            return (await _econtService.GetStreets(cityId.ToString())).Select(x => new NomenclatureDTO<int>() { Id = x.Id??0, Name = x.Name }).ToList();
        }
    }
}
