using Models.DTOs.Shipping;
using Models.DTOs.Shipping.Econt;

namespace Services.Shipping
{
    public interface IShippingService
    {
        public string GenerateWaybill(int orderId);
        public Task<HttpResponseMessage> SendShipmentAsync(ShippingDetails shippingDetails);
        public Task<HttpResponseMessage> ValidateAddress(AddressDTO addressDTO);
        //public List<OrderTrackingDTO> GetTrackingDetails(int orderId);

    }
}
