using Models.DTOs.Shipping;
using Models.DTOs.Shipping.Econt;

namespace Services.Shipping
{
    public class SpeedyShippingService : IShippingService
    {
        public Task<List<CityDTO>> EcontGetCities(string countryCode)
        {
            throw new NotImplementedException();
        }

        public Task<List<CountryDTO>> GetCountries()
        {
            throw new NotImplementedException();
        }

        public Task<List<QuarterDTO>> GetQuarters(int cityId)
        {
            throw new NotImplementedException();
        }

        public Task<List<StreetDTO>> EcontGetStreets(string cityId)
        {
            throw new NotImplementedException();
        }

        public string GenerateWaybill(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> SendShipmentAsync(ShippingDetails shippingDetails)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> ValidateAddress(ShippingAddressDTO addressDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<CityDTO>> GetCities(string countryCode)
        {
            throw new NotImplementedException();
        }

        public Task<List<StreetDTO>> GetStreets(string cityId)
        {
            throw new NotImplementedException();
        }

        public ClientDTO GetSenderClient()
        {
            throw new NotImplementedException();
        }

        public AddressDTO GetSenderAddress()
        {
            throw new NotImplementedException();
        }
    }
}
