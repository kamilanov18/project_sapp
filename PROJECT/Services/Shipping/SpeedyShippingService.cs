﻿using Models.DTOs.Shipping;
using Models.DTOs.Shipping.Econt;

namespace Services.Shipping
{
    public class SpeedyShippingService : IShippingService
    {
        public Task<List<CityDTO>> EcontGetCities(string countryCode)
        {
            throw new NotImplementedException();
        }

        public Task<List<CountryDTO>> EcontGetCountries()
        {
            throw new NotImplementedException();
        }

        public Task<List<QuarterDTO>> EcontGetQuarters(int cityId)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> EcontGetStreets(int cityId)
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
    }
}
