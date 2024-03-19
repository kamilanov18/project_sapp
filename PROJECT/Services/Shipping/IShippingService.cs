using Models.DTOs.Shipping;
using Models.DTOs.Shipping.Econt;

namespace Services.Shipping
{
    public interface IShippingService
    {
        public string GenerateWaybill(int orderId);
        public Task<HttpResponseMessage> SendShipmentAsync(ShippingDetails shippingDetails);
        public Task<HttpResponseMessage> ValidateAddress(ShippingAddressDTO addressDTO);
        public Task<List<CountryDTO>> GetCountries();
        public Task<List<CityDTO>> GetCities(string countryCode);
        public Task<List<StreetDTO>> GetStreets(string cityId);
        public Task<List<QuarterDTO>> GetQuarters(int cityId);

        public ClientDTO GetSenderClient();
        public AddressDTO GetSenderAddress();
    }
}
