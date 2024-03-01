﻿using Models.DTOs.Shipping;
using Models.DTOs.Shipping.Econt;

namespace Services.Shipping
{
    public interface IShippingService
    {
        public string GenerateWaybill(int orderId);
        public Task<HttpResponseMessage> SendShipmentAsync(ShippingDetails shippingDetails);
        public Task<HttpResponseMessage> ValidateAddress(ShippingAddressDTO addressDTO);
        public Task<List<CountryDTO>> EcontGetCountries();
        public Task<List<CityDTO>> EcontGetCities(string countryCode);
        public Task<List<StreetDTO>> EcontGetStreets(string cityId);
        public Task<List<QuarterDTO>> EcontGetQuarters(int cityId);
        //public List<OrderTrackingDTO> GetTrackingDetails(int orderId);

    }
}