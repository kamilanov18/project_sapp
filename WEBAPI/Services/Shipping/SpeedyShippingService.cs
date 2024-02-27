using Models.DTOs.Shipping;
using Models.DTOs.Shipping.Econt;

namespace Services.Shipping
{
    public class SpeedyShippingService : IShippingService
    {
        public string GenerateWaybill(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> SendShipmentAsync(ShippingDetails shippingDetails)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> ValidateAddress(AddressDTO addressDTO)
        {
            throw new NotImplementedException();
        }
    }
}
